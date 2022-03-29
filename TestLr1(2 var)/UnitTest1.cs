using NUnit.Framework;
using lb1;

namespace TestLr1_2_var_
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void isEmpty()
        {
            Queue<int> queue = new Queue<int>();
            bool expect = true;
            Assert.AreEqual(expect,queue.isEmpty());
        }
        [Test]
        public void Dequeue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(5);
            queue.Dequeue();
            int expect = 2;
            Assert.AreEqual(expect, queue.Size);
        }
        [Test]
        public void Peek()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(5);
            int expect = 5;
            Assert.AreEqual(expect, queue.Peek());
        }
        [Test]
        public void Print()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(5);
            string expect = " 1 2 5";
            Assert.AreEqual(expect, queue.Print());
        }
    }
}