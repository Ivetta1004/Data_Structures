using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    internal partial class DoublyLinkedList<T>
    {
        public partial class Node<T>
        {
            public T Value { get; private set; }
            public Node<T> NextNode { get; internal set; }
            public Node<T> PrevNode { get; internal set; }

            public Node(T value)
            {
                Value = value;
            }
        }
    }
}
