using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace lb1

{
    public interface IQueue1<T>
    {
        void Enqueue(T value);
        T Dequeue();
        T Peek();
        string Print();
        bool isEmpty();
    }

    class Node<T>
    {
        public Node(T value, Node<T> next = null) { Value = value; Next = next; }
        public T Value;
        public Node<T> Next;
    }
    public class Queue<T> : IQueue1<T>
    {
        public int Size;
        private Node<T> First;
        private Node<T> Last;

        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
            if (Last == null) { First = node; Last = node; }
            else { Last.Next = node; Last = node; }
            Size++;
        }
        public T Peek()
        {
            if (isEmpty() == true)
            {
                throw new Exception("Попытка получить элемент в пустой очереди!");
            }
            Node<T> node = Last;
            return node.Value;
        }
        public bool isEmpty()
        {
            if (Size == 0)
            {
                return true;
            }
            return false;
        }
        public T Dequeue()
        {
            Node<T> Temp = First;
            if (Size == 1) // удаление единственного элемента
            {
                First = null;
                Last = null;
                Size--;
                return Temp.Value;
            }
            if (Size > 1) // удаление первого элемента
            {
                First = First.Next;
                Temp.Next = null;
                Size--;
                return Temp.Value;
            }
            else { throw new System.Exception("Попытка удаления из пустой очереди"); }
        }
        public string Print()
        {
            string s = "";
            Node<T> Temp = First;
            Console.Write("Очередь: ");
            while (Temp != null)
            {
                s += " " + Temp.Value;
                Temp = Temp.Next;
            }
            return s;
        }
    }
    class Program
    {
        public static void Main(string[]args)
        {

        }
    }
}
