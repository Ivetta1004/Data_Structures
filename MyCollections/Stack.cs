using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    internal class Stack<T>
    {
        DoublyLinkedList<T> _items = new DoublyLinkedList<T>();

        public int Count { get => _items.Count; }

        public void Clear()
        {
            _items.Clear();
        }

        public bool Contains(T obj)
        {
            return _items.Contains(obj);
        }

        public T Peek()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            return _items.Last.Value;
        }

        public T[] ToArray()
        {
            return _items.ToArray();
        }

        public void Push(T value)
        {
            _items.Add(value);
        }

        public T Pop()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            var result = _items.Last.Value;
            _items.RemoveLast();
            return result;
        }
    }
}
