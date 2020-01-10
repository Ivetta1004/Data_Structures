using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    internal partial class DoublyLinkedList
    {
        public partial class Node
        {
            public object Value { get; private set; }
            public Node NextNode { get; internal set; }
            public Node PrevNode { get; internal set; }

            public Node(object value)
            {
                Value = value;
            }
        }
    }
}
