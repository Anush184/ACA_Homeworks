using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection
{
    public class CustomCollection<T> : ICollection<T>
    {
        public event EventHandler<ElementChangedEventArgs<T>>? ElementAdded;
        public event EventHandler<ElementChangedEventArgs<T>>? ElementRemoved;
        private  T[] _items;

        public CustomCollection()
        {
            _items = Array.Empty<T>();
        }

        public int Count { get; private set; }

        public bool IsReadOnly => false;

        public void Add(T item)
        {
           EnsureCapacity();
           _items[Count] = item;
           Count++;

            OnElementAdded(new ElementChangedEventArgs<T>(item));

        }
        protected virtual void OnElementAdded(ElementChangedEventArgs<T> e)
        {
            ElementAdded?.Invoke(this, e);
        }
       private void EnsureCapacity()
{
    if (Count == _items.Length)
    {
        int newCapacity = _items.Length == 0 ? 4 : _items.Length * 2;
        Array.Resize(ref _items, newCapacity);
    }
}
       

        public void Clear()
        {
            Array.Clear(_items, 0, Count);
        }

        public bool Contains(T item)
        {
            return Array.IndexOf(_items, item, 0, Count) >= 0;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Array.Copy(_items, 0, array, arrayIndex, Count);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_items.Take(Count)).GetEnumerator();
        }

        public bool Remove(T item)
        {
            var index = Array.IndexOf(_items, item);
            if (index != -1)
            {
                OnElementRemoved(new ElementChangedEventArgs<T>(item));
                RemoveAt(index);
                return true;
            }
            return false;
        }

        protected virtual void OnElementRemoved(ElementChangedEventArgs<T> e)
        {
            ElementRemoved?.Invoke(this, e);
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _items.Length)
                throw new IndexOutOfRangeException("Index is out of range.");

            T[] newArray = new T[_items.Length - 1];
            Array.Copy(_items, 0, newArray, 0, index);
            Array.Copy(_items, index + 1, newArray, index, newArray.Length - index);
            _items = newArray;
            Count--;
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException("Index is out of range.");

                return _items[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException("Index is out of range.");

                _items[index] = value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void ShowElements()
        {
            Console.WriteLine("Elements in the CustomCollection:");
            for (int i = 0; i < Count; i++)
            {
                Console.Write(this[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
