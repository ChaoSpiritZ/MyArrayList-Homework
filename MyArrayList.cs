using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Homework
{
    class MyArrayList
    {
        private object[] _array;
        private const int _sizeJump = 10;
        private int _objectCount;

        //constructors
        public MyArrayList()
        {
            _array = new object[10];
            _objectCount = 0;
        }

        public MyArrayList(int size)
        {
            _array = new object[size];
            _objectCount = 0;
        }

        //functions

        public void Get(int index)
        {
            if(index < _array.Length)
            {
                Console.WriteLine(_array[index]);
            }
            else
            {
                Console.WriteLine("Array not big enough to show what's there");
            }
        }

        public int Count()
        {
            return _objectCount;
        }

        public int Capacity()
        {
            return _array.Length;
        }

        public void Add(object obj)
        {
            if(_objectCount >= _array.Length)
            {
                ExpandArray();
            }
            _array[_objectCount] = obj;
            _objectCount++;

        }

        public void Insert(int index, object obj)
        {
            if (_objectCount >= _array.Length)
            {
                ExpandArray();
            }
            object[] tmp = new object[_array.Length];
            for(int i = 0;i < index;i++)
            {
                tmp[i] = _array[i];
            }
            tmp[index] = obj;
            for(int i = index;i < _objectCount;i++)
            {
                tmp[i + 1] = _array[i];
            }
            _array = tmp;
            _objectCount++;
        }

        public void Clear()
        {
            for(int i = 0;i < _array.Length;i++)
            {
                _array[i] = null;
            }
        }

        public void RemoveAt(int index)
        {
            if(index < _objectCount)
            {
                _array[index] = null;

                object[] tmp = new object[_array.Length];

                for(int i = 0;i < index;i++)
                {
                    tmp[i] = _array[i];
                }
                for(int i = index;i < _objectCount - 1;i++)
                {
                    tmp[i] = _array[i + 1];
                }
                _array = tmp;
                _objectCount--;
            }
            else
            {
                Console.WriteLine("Object does not exist");
            }
        }

        private void ExpandArray()
        {
            object[] tmp = new object[_array.Length * _sizeJump];

            for (int i = 0; i < _objectCount; i++)
            {
                tmp[i] = _array[i];
            }
            _array = tmp;
        }

    }
}
