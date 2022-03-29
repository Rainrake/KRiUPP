using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using lb1;

namespace lr1

{

    public class Queue<T>: IQueue1<T>
    {
        private T[] _array;
        private int _head;
        private int _tail;
        private int _size;
        public int Count { get; set; }
        public Queue(int Size)
        {
            this._size = Size;
            this._array = new T[Size];
        }
        public T Dequeue()
        {
            if (Count == 0)
                throw new InvalidOperationException();
            T local = _array[_head];
            _array[_head] = default(T);
            _head = (_head + 1) % _array.Length;
            Count--;
            return local;
        }
        public bool isEmpty()
        {
            if (_array.Length == 0)
            {
                return true;
            }
            return false;
        }
        public T Peek ()
        {
            T s = _array[_array.Length - 1];
            return s;
        }
        public string Print()
        {
            string s = "";
            for (int i = 0; i < _array.Length; i++)
            {
                s += " " + _array[i];
            }
            return s;
        }
        public void Enqueue(T item)
        {
            if (Count == _array.Length+1)
            {
                throw new Exception("Переполнение очереди");
            }
            _array[_tail] = item;
            _tail = (_tail + 1) % _array.Length;
            Count++;
        }
    }
    class Program
    {
        public static void Main(string[]args)
        {
            Queue<int> queue = new Queue<int>(5);
            queue.Enqueue(1); 
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(5);
            queue.Enqueue(4);
            Console.WriteLine(queue.Peek());
            Console.Write(queue.Print());
        }
    }
}