using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    internal class Stack
    {
        DoublyLinkedList _items = new DoublyLinkedList();

        public int Count { get => _items.Count; }

        public void Clear()
        {
            _items.Clear();
        }

        public bool Contains(object obj)
        {
            return _items.Contains(obj);
        }

        public object Peek()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            return _items.Last.Value;
        }

        public object[] ToArray()
        {
            return _items.ToArray();
        }

        public void Push(object value)
        {
            _items.Add(value);
        }

        public object Pop()
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
