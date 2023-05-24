using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGerericClasses;


public class SimpleQueue<T>
{
    private Node<T> _head;
    private Node<T> _tail;

    public SimpleQueue()
    {
        _head = null!;
        _tail = null!;
    }
    // Returns true if the queue is empty and false is it isn’t
    public bool IsEmpty()
    {
        return _head == null;
    }
    // Adds an item to the tail of the queue 
    public void Enqueue(T item)
    {
        Node<T> newNode = new Node<T>(item);
        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _tail.Next = newNode;
            _tail = newNode;
        }
    }
    // Removes and returns the item at the head of the queue
    public T Dequeue()
    {
        if (_head == null)
        {
            Console.WriteLine("The queue is empty");
            return default(T)!;
        }
        T value = _head.Value;
        _head = _head.Next;
        if (_head == null)
        {
            _tail = null!;
        }
        return value;
    }

    // Shows the number of items currently in the queue
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
    // Printing out the elements of the Queue
    public void PrintLinkedList()
    {
        Node<T> current = _head;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}