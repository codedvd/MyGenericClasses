using System;
using System.Drawing;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGerericClasses
{
    class TestCases
    {
        public static void Main(string[] args)
        {
            _ = new TestCases();
            // StackTesting();

            //LinkedListing<int> list = new LinkedListing<int>();
            //list.Add(200);
            //list.Add(2);
            //list.Add(13);
            //Console.WriteLine(list.ListSize());

            SimpleStack<string> names = new();
            names.Push("David");
            names.Push("philip");
            names.Pop();
            Console.WriteLine(names.Peek());
            Console.WriteLine(names.Size);
            Console.WriteLine("is the stack empty?: " + names.IsEmpty());


            //SimpleQueue<object> simluation = new();
            //simluation.Enqueue(true);
            //simluation.Enqueue("David");
            //simluation.Enqueue(23);
            //simluation.Enqueue('O');
            //Console.WriteLine("Size of the Queue is: " + simluation.Size());
            //simluation.Dequeue();
            //Console.WriteLine("After Dequeuing, the size of the queue is now: " + simluation.Size());
            //Console.WriteLine("Is the Queue empty? " + simluation.IsEmpty());

        }

        //static void StackTesting()
        //{
        //    // Test Cases
        //    SimpleStack<int> stack = new SimpleStack<int>();
        //    Console.WriteLine("Stack is empty?: " + stack.IsEmpty());
        //    stack.Push(6);
        //    stack.Push(12);

        //    Console.WriteLine("After pushing Stack is empty?: " + stack.IsEmpty());

        //    stack.Push(14);
        //    stack.Push(23);

        //    Console.WriteLine("Peek: " + stack.Peek());
        //    Console.WriteLine("After popping: " + stack.Pop());

        //    Console.WriteLine(stack.Peek());

        //    Console.WriteLine("Size of the array is now: " + stack.Size);
        //}
    }
}