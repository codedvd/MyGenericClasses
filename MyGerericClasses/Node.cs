using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGerericClasses;

// My Node Class
public class Node<T>
{
    public T Value { get; set; } = default!;
    public Node<T> Next { get; set; } = default!;

    public Node(T value)
    {
        Value = value;
        Next = null!;
    }
}

