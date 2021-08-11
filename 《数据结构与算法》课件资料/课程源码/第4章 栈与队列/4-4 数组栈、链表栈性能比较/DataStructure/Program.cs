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
        //对栈执行N次入栈和出栈操作
        //对于TestStack方法，不管是测试数组栈还是链表栈它们的时间复杂度都是O（n）
        //运行时间和数据规模成正比的关系
        public static long TestStack(IStack<int> stack,int N)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            for (int i = 0; i < N; i++)
                stack.Push(i);
            for (int i = 0; i < N; i++)
                stack.Pop();
            t.Stop();
            return t.ElapsedMilliseconds;
        }

        //测试不同底层实现的栈性能
        //ArrayStack和linkedListStack耗时消耗巨大
        //由于链表的实现需要不断的new空间，所以内存操作耗时较大。
        //而对于数组操作，是对连续空间进行操作的，C#底层对连续空间的访问有非常好的优化。
        //再加上数据规模增大以后，动态数组resize调用的频次其实很小，所以得到这个测试结果是正常的：）
        static void Main(string[] args)
        {

            int N = 20000000;

            Array1Stack<int> array1Stack = new Array1Stack<int>(N);
            long t1 = TestStack(array1Stack, N);
            Console.WriteLine("Array1Stack'time: " + t1 + "ms");

            //LinkedList1Stack<int> linkedList1Stack = new LinkedList1Stack<int>();
            //long t2 = TestStack(linkedList1Stack, N);
            //Console.WriteLine("LinkedList1Stack'time: " + t2 + "ms");

            //C#提供的栈是基于数组实现的。
            Stack<int> stack = new Stack<int>(N);
            Stopwatch t = new Stopwatch();
            t.Start();
            for (int i = 0; i < N; i++)
                stack.Push(i);
            for (int i = 0; i < N; i++)
                stack.Pop();
            t.Stop();
            Console.WriteLine("Stack'time: " + t.ElapsedMilliseconds + "ms");


            Console.Read();
        }
    }
}
