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
        //计算数组队列和循环队列执行N次入队和出队操作的运行时间
        //对于TestQueue方法：
        //数组队列为O(n^2)  运行时间和数据规模的增长成平方倍的关系 
        //循环队列为O(n）  运行时间和数据规模的增长成正比关系
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
            int N = 200000;

            //数组队列
            Array1Queue<int> array1Queue = new Array1Queue<int>();
            long t1 = TestQueue(array1Queue, N);
            Console.WriteLine("Array1Queue'time: " + t1 + "ms");

            //循环队列
            Array2Queue<int> array2Queue = new Array2Queue<int>();
            long t2 = TestQueue(array2Queue, N);
            Console.WriteLine("Array2Queue'time: " + t2 + "ms");

            //C#自带的循环队列
            Queue<int> queue = new Queue<int>();
            Stopwatch t = new Stopwatch();
            t.Start();
            for (int i = 0; i < N; i++)
                queue.Enqueue(i);
            for (int i = 0; i < N; i++)
                queue.Dequeue();
            t.Stop();
            Console.WriteLine("Queue'time: " + t.ElapsedMilliseconds + "ms");

            Console.Read();
        }
    }
}
