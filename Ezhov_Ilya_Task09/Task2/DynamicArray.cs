using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class DynamicArray<T> : IEnumerable where T : new()
    {
        private int _length;
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }
        private T[] _array;
        public int Capacity
        {
            get
            {
                return _array.Length;
            }
        }

        public DynamicArray()
        {
            _array = new T[8];
            Length = 0;
        }
        public DynamicArray(int inputLength)
        {
            _array = new T[inputLength];
            Length = 0;
        }
        public DynamicArray(T[] inputArray)
        {
            _array = inputArray;
            Length = inputArray.Length;
        }
        // TASK 9-2
        public DynamicArray(IEnumerable<T> collection)
        {
            _array = new T[collection.Count()];
            int i = 0;
            foreach (T item in collection)
            {
                _array[i] = item;
                i++;
            }
        }

        public void Add(T input)
        {
            if (Length >= Capacity)
            {
                Array.Resize(ref _array, Capacity * 2);
            }
            _array[Length] = input;
            Length++;
        }
        public void AddRange(T[] inputArray)
        {
            if (inputArray.Length + Length >= Capacity)
            {
                Array.Resize(ref _array, Capacity + inputArray.Length);
            }
            Array.Copy(inputArray, 0, _array, Length, inputArray.Length);
            Length += inputArray.Length;
        }
        public void ShowArray()
        {
            Console.WriteLine($"Array capacity: {Capacity}. Array length: {Length}. Array elements:");
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"[{i}] = {_array[i],4}\t");
                if (i != 0 && (i % 5 == 0)) { Console.WriteLine(); }
            }
            Console.WriteLine("\n\n");
        }
        public bool Remove(int index)
        {
            if (_array[index] != null && index >= 0 && index < Length)
            {
                for (int i = index; i < Length - 1; i++)
                {
                    _array[i] = _array[i + 1];
                }
                _array[Length - 1] = default(T);
                Length--;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Insert(T input, int index)
        {
            if (Length + 1 >= Capacity)
            {
                Array.Resize(ref _array, Capacity * 2);
            }
            if (index >= 0 && index < Length)
            {
                Array.Copy(_array, index, _array, index + 1, (Length - index));
                _array[index] = input;
                Length++;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The index is outside the bounds of the array.");
            }
        }
        //not tested
        public IEnumerator GetEnumerator()
        {
            return _array.GetEnumerator();
        }

        public T this[int index]
        {
            get
            {
                if (index < Length && index >= 0)
                {
                    return _array[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The index is outside the bounds of the array.");
                }
            }
            set
            {
                if (index < Length && index >= 0)
                {
                    _array[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The index is outside the bounds of the array.");
                }

            }
        }
    }
}
