using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    internal class MyLinkedList
    {
        internal class Node
        {
            public object Value { get; private set; }
            public Node NextNode { get; internal set; }
        }

        public int Count { get; private set; }
        public Node First { get; private set; }
        public Node Last { get; private set; }

        public void Add(object obj)
        {
            if (First == null)
            {
                First = (Node)obj;
            }
            else if (obj is Node newNode)
            {
                Last.NextNode = newNode;
                Last = newNode;
            }
            Count++;
        }

        public void AddFirst(object obj)
        {
            if (obj is Node newNode)
            {
                newNode.NextNode = First;
                First = newNode;
            }
            if (Count == 0)
            {
                Last = First;
            }
            Count++;
        }

        public void Insert(Node node, object obj)
        {
            if (First == null)
            {
                First = node;
                Last = node;
                return;
            }
            Node currentNode = First;
            do
            {
                if (currentNode.Equals(node) && obj is Node newNode)
                {
                    newNode.NextNode = currentNode;
                    currentNode = newNode;
                    Count++;
                    break;
                }
                currentNode = currentNode.NextNode;
            } while (currentNode != null && currentNode.NextNode != null);
            if (Last == null)
            {
                Last = First;
            }
        }

        public void Clear()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        public bool Contains(object obj)
        {
            Node currentNode = First;
            while (currentNode != null)
            {
                if (obj.Equals(currentNode))
                    return true;
                currentNode = currentNode.NextNode;
            }
            return false;
        }

        public object[] ToArray()
        {
            Node currentNode = First;
            Node[] arrayNode = new Node[Count];
            int i = 0;
            while (currentNode != null)
            {
                arrayNode[i] = currentNode;
                i++;
                currentNode = currentNode.NextNode;
            }
            return arrayNode;
        }
    }
}
