using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGerericClasses
{
    class TestCases
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------- LINKEDLIST IMPLEMENTATION");
            LinkedListing<int> list = new LinkedListing<int>();
            list.Add(200);
            list.Add(2);
            list.Add(13);
            Console.WriteLine("Removed an element? " + list.Remove(2));
            Console.WriteLine("Does this element exist? " + list.Check(13));
            Console.WriteLine("The index of the element is: " + list.Index(200));

            Console.WriteLine("----------------------------------------------------- STACK IMPLEMENTATION");
            SimpleStack<string> names = new();
            names.Push("David");
            names.Push("philip");
            names.Push("Joseph");
            Console.WriteLine("I poped out: " + names.Pop());
            Console.WriteLine("After popping, i peeked out this: " + names.Peek());
            Console.WriteLine("The Size of the stack is now: " + names.Size);
            Console.WriteLine("is the stack empty?: " + names.IsEmpty());

            Console.WriteLine("----------------------------------------------------- QUEUE IMPLEMENTATION");
            SimpleQueue<object> simluation = new();
            simluation.Enqueue("David");
            simluation.Enqueue(23);
            simluation.Enqueue("Josh");
            Console.WriteLine("Size of the Queue is: " + simluation.Size);
            Console.WriteLine("I dequeued this: " + simluation.Dequeue());
            Console.WriteLine("After Dequeuing, the size of the queue is now: " + simluation.Size);
            Console.WriteLine("Is the Queue empty? " + simluation.IsEmpty());
        }
    }
}