using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    internal partial class DoublyLinkedList<T>
    {
        public int Count { get; private set; }
        public Node<T> First { get; private set; }
        public Node<T> Last { get; private set; }

        public void Add(T obj)
        {
            Node<T> node = new Node<T>(obj);
            if (First == null)
            {
                First = node;
                Last = node;
            }
            else
            {
                node.PrevNode = Last;
                Last.NextNode = node;
                Last = node;
                node.NextNode = null;
            }
            Count++;
        }

        public void AddFirst(T obj)
        {
            Node<T> node = new Node<T>(obj);
            node.NextNode = First;
            node.PrevNode = null;
            if (First != null)
            {
                First.PrevNode = node;
            }
            First = node;
            Count++;
        }

        public void Remove(T obj)
        {
            Node<T> previous = null;
            Node<T> current = First;
            Node<T> newNode = new Node<T>(obj);
            while (current != null)
            {
                if (current.Value.Equals(newNode.Value))
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
            Node<T> currentNode = First;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(obj))
                {
                    return true;
                }
                currentNode = currentNode.NextNode;
            }
            return false;
        }

        public T[] ToArray()
        {
            T[] array = new T[Count];
            int index = 0;
            Node<T> currentNode = First;
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

