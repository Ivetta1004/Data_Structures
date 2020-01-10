using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    internal class Queue
    {
        private DoublyLinkedList _items = new DoublyLinkedList();

        public int Count { get => _items.Count; }

        public void Enqueue(object obj)
        {
            _items.Add(obj);
        }

        public object Dequeue()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            object result = _items.First.Value;
            _items.RemoveFirst();
            return result;
        }

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
                throw new InvalidOperationException("The queue is empty");
            }
            return _items.First.Value;
        }

        public void ToArray()
        {
            _items.ToArray();
        }
    }
}
