using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {

        private static long TestQueue(IQueue<int> queue, int N)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            for (int i = 0; i < N; i++)
                queue.Enqueue(i);
            for (int i = 0; i < N; i++)
                queue.Dequeue();
            t.Stop();
            return t.ElapsedMilliseconds;
        }

        static void Main(string[] args)
        {
            int N = 100000;

            //O(n^2) 只有头指针的链表
            LinkedList1Queue<int> linkedList1Queue = new LinkedList1Queue<int>();
            long t1 = TestQueue(linkedList1Queue, N);
            Console.WriteLine("linkedList1Queue'time: " + t1 + "ms");

            //O(n)  具备头和尾指针的链表
            LinkedList2Queue<int> linkedList2Queue = new LinkedList2Queue<int>();
            long t2 = TestQueue(linkedList2Queue, N);
            Console.WriteLine("linkedList2Queue'time: " + t2 + "ms");


            Console.Read();
        }
    }
}
