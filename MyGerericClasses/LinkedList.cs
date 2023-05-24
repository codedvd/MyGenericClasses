using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGerericClasses
{
    public class LinkedListing<T>
    {
        private Node<T> Head;
        private Node<T> Tail;
        public LinkedListing()
        {
            Head = null;
            Tail = null;
        }

        // Adds an item to the tail of the LinkedList and returns the linked list’s size 
        public void Add(T item)
        {
            Node<T> node = new(item);
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
        }
        //removes the first occurrence of an item in the linked list,
        //returns true if said item is found and removed or returns false otherwise
        public bool Remove(T item)
        {
            Node<T> current = Head;
            Node<T> previous = null!;

            while (current != null)
            {
                if (current.Value!.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                    }
                    else
                    {
                        Head = current.Next;
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }
        // Checks for a specified item in the linked list. Returns a Boolean
        public bool Check(T item)
        {
            Node<T> current = Head;

            while (current != null)
            {
                if (current.Value!.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        // Returns the index of an item or returns -1 if the item isn’t found
        public int Index(T item)
        {
            Node<T> current = Head;
            int index = 0;

            while (current != null)
            {
                if (current.Value!.Equals(item))
                {
                    return index;
                }
                index++;
                current = current.Next;
            }
            return -1;
        }

        public void PrintLinkedList()
        {
            Node<T> current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        //public int ListSize()
        //{
        //    Node<T> current = Head;
        //    int count = 0;

        //    while (current != null)
        //    {
        //        count++;
        //        current = current.Next;
        //    }

        //    return count;
        //}
    }
}
