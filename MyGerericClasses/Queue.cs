using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGerericClasses;


public class SimpleQueue<T>
{
    private LinkedListing<T> queue;
    public SimpleQueue()
    {
        queue = new LinkedListing<T>();
    }

    // Returns true if the queue is empty and false is it isn’t
    public bool IsEmpty()
    {
        if(queue == null)
        {
            return true;
        }
        return false;
    }

    // Adds an item to the tail of the queue 
    public void Enqueue(T item)
    {
        queue.Add(item);
    }

    // Removes and returns the item at the head of the queue
    public T Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine(("Queue is empty"));
        }
        T item = queue.Head.Value;
        queue.Remove(item);
        return item;
    }

    // Shows the number of items currently in the queue
    public int Size()
    {
        return queue.ListSize();
    }
}