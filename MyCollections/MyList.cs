using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    internal class MyList<T>
    {
        private T[] _array;
        private int _index;
        private int _capacity = 10;

        public int Count
        {
            get { return _array.Length; }
        }

        public T this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }

        public MyList(int capacity)
        {
            _capacity = capacity;
            _array = new T[capacity];
        }

        public MyList() => InitArray();

        private void InitArray()
        {
            _array = new T[_capacity];
        }

        private void ReInitArray()
        {
            T[] tempArr = _array;
            _array = new T[_capacity];

            if (_array != null)
            {
                for (int i = 0; i < tempArr.Length; i++)
                {
                    _array[i] = tempArr[i];
                }
            }
        }

        public void Add(T obj)
        {
            if (_index == _capacity)
            {
                _capacity *= 2;
                ReInitArray();
            }
            _array[_index] = obj;
            _index++;
        }

        public void Insert(int index, T obj)
        {
            T[] tempArr = new T[_array.Length + 1];
            for (int i = 0; i < index; i++)
            {
                tempArr[i] = _array[i];
            }
            for (int i = index; i < _array.Length; i++)
            {
                tempArr[i + 1] = _array[i];
            }
            tempArr[index] = obj;
            _array = tempArr;
        }

        public void Remove(T obj)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(obj))
                    _array[i] = default(T);
            }
        }

        public void RemoveAt(int index)
        {
            T[] tempArr = new T[_array.Length - 1];
            for (int i = 0; i < index; i++)
            {
                tempArr[i] = _array[i];
            }
            for (int i = index; i < _array.Length; i++)
            {
                tempArr[i] = _array[i + 1];
            }
            _array = tempArr;
        }

        public void Clear()
        {
            InitArray();
        }

        public bool Contains(T obj)
        {
            foreach (T ar in _array)
            {
                if (ar.Equals(obj))
                    return true;
            }
            return false;
        }

        public int IndexOf(T obj)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(obj))
                    return i;
            }
            return -1;
        }

        public T[] ToArray()
        {
            T[] tempArr = new T[_array.Length];
            for (int i = 0; i < tempArr.Length; i++)
            {
                tempArr[i] = _array[i];
            }
            return tempArr;
        }

        public void Reverse()
        {
            T[] tempArr = new T[_array.Length];
            for (int i = _array.Length - 1, j = 0; i >= 0; i--, j++)
            {
                tempArr[j] = _array[i];
            }
            _array = tempArr;
        }

        public void Print()
        {
            foreach (var arr in _array)
            {
                Console.Write(arr + ";");
            }
        }
    }
}
