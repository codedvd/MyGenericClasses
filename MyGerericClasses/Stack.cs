using MyGerericClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SimpleStack<T>
{
    private Node<T> _head;

    public SimpleStack()
    {
        _head = null;
    }
    // Returns true if the stack is empty and false it it isn't
    public bool IsEmpty()
    {
        return _head == null;
    }
    // Adds an item to the top of the stack
    public void Push(T item)
    {
        Node<T> newNode = new Node<T>(item);
        if (_head == null)
        {
            _head = newNode;
        }
        else
        {
            newNode.Next = _head;
            _head = newNode;
        }
    }
    // Removes and returns the last item added to the stack
    public T Pop()
    {
        if (_head == null)
        {
            Console.WriteLine("The stack is empty");
            return default(T)!;
        }
        T value = _head.Value;
        _head = _head.Next;
        return value;
    }
    // Returns the last item added to the stack without removing it from the stack
    public T Peek()
    {
        if (_head == null)
        {
            Console.WriteLine("The stack is empty");
            return default(T);
        }
        return _head.Value;
    }
    // Shows the number of items currently in the stack 
    public int Size
    {
        get
        {
            int count = 0;
            Node<T> current = _head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
    }
}

