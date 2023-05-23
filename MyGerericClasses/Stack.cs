using MyGerericClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
public class SimpleStack<T>
{
    // readOnly keyword, it ensures that the value assigned to the
    // field can only be set at the time of declaration
    private readonly LinkedListing<T> _list;

    public SimpleStack() { 
        _list = new LinkedListing<T>();
    }

    // Returns true if the stack is empty and false it it isn't
    public bool IsEmpty()
    {
        if (_list.Head == null)
        {
            return true;
        }
        return false;
    }

    // Adds an item to the top of the stack
    public void Push(T item)
    {
            _list.Add(item);
    }

    // Removes and returns the last item added to the stack
    public T Pop()
    {
        if (_list.Head == null)
        {
            Console.WriteLine("The stack is empty");
        }
        T value = _list.RemoveandPop();

        return value;
    }

    // Returns the last item added to the stack without removing it from the stack
    public T Peek()
    {
        if (_list.Head == null)
        {
            Console.WriteLine("The stack is empty");
        }
        return _list.LastItem();
    }

    // Shows the number of items currently in the stack 
    // Size is a read only property type int
    public int Size
    {
        get
        {
            return _list.ListSize();
        }
    }

}

