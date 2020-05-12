using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }
        public T Value { get; private set; }
        public Node<T> NextNode { get; internal set; }
    }

    public class MyLinkedList<T> : IEnumerable<T>
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
                Last.NextNode = node;
                Last = node;
            }
            Count++;
        }

        public void AddFirst(T obj)
        {
            Node<T> node = new Node<T>(obj);
            node.NextNode = First;
            First = node;
            if (Count == 0)
            {
                Last = First;
            }
            Count++;
        }

        public void Insert(Node<T> node, T obj) // previous node, we have to insert a new node after a given node
        {
            if (First == null)
            {
                First = node;
                Last = node;
                return;
            }
            Node<T> currentNode = First;
            do
            {
                if (currentNode.Value.Equals(node.Value))
                {
                    node = new Node<T>(obj);
                    node.NextNode = currentNode.NextNode;
                    currentNode.NextNode = node;
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

        public bool Contains(T obj)
        {
            Node<T> currentNode = First;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(obj))
                    return true;
                currentNode = currentNode.NextNode;
            }
            return false;
        }

        public bool Remove(T obj)
        {
            Node<T> currentNode = First;
            Node<T> previous = null;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(obj))
                {
                    if (previous != null)
                    {
                        previous.NextNode = currentNode.NextNode;
                        if (currentNode.NextNode == null)
                            Last = previous;
                    }
                    else
                    {
                        First = First.NextNode;
                        if (First == null)
                        {
                            Last = null;
                        }
                    }
                    Count--;
                    return true;
                }
                previous = currentNode;
                currentNode = currentNode.NextNode;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> currentNode = First;
            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.NextNode;
            }
        }
    }
}
