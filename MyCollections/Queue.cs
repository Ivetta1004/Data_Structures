using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    internal class Queue<T>
    {
        private DoublyLinkedList<T> _items = new DoublyLinkedList<T>();

        public int Count { get => _items.Count; }

        public void Enqueue(T obj)
        {
            _items.Add(obj);
        }

        public T Dequeue()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            T result = _items.First.Value;
            _items.RemoveFirst();
            return result;
        }

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
