using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    internal partial class DoublyLinkedList
    {
        public int Count { get; private set; }
        public Node First { get; private set; }
        public Node Last { get; private set; }

        public void Add(object obj)
        {
            if (Count == 0)
            {
                First = (Node)obj;
            }
            if (obj is Node newNode)
            {
                Last.NextNode = newNode;
                newNode.PrevNode = Last;
            }
            Last = (Node)obj;
            Count++;
        }

        public void AddFirst(object obj)
        {
            Node currentNode = First;
            if (obj is Node newNode)
            {
                First.NextNode = currentNode;
                First = newNode;
            }
            if (Count == 0)
            {
                Last = First;
            }
            else
            {
                currentNode.PrevNode = First;
            }
            Count++;
        }

        public void Remove(object obj)
        {
            Node previous = null;
            Node current = First;
            while (current != null)
            {
                if (current == obj)
                {
                    if (previous != null)
                    {
                        previous.NextNode = current.NextNode;
                        if (current.NextNode == null)
                        {
                            Last = previous;
                        }
                        else
                        {
                            current.NextNode.PrevNode = previous;
                        }
                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }
                }
                previous = current;
                current = current.NextNode;
            }
        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                First = First.NextNode;
                Count--;
                if (Count == 0)
                {
                    Last = null;
                }
                else
                {
                    First.PrevNode = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    First = null;
                    Last = null;
                }
                else
                {
                    Last.PrevNode.NextNode = null;
                    Last = Last.PrevNode;
                }
                Count--;
            }
        }

        public bool Contains(object obj)
        {
            Node currentNode = First;
            while (currentNode != null)
            {
                if (obj is Node newNode)
                {
                    return true;
                }
                currentNode = currentNode.NextNode;
            }
            return false;
        }

        public object[] ToArray()
        {
            object[] array = new object[Count];
            int index = 0;
            Node currentNode = First;
            while (currentNode != null)
            {
                array[index] = currentNode.Value;
                index++;
                currentNode = currentNode.NextNode;
            }
            return array;
        }

        public void Clear()
        {
            First = null;
            Last = null;
            Count = 0;
        }
    }
}
