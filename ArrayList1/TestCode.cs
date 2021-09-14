using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1
{
    class TestCode
    {
        public static void Test(string[] args)
        {
            //测试Array2(支持泛型的数组)代码
            Array2<int> arr1 = new Array2<int>(10);
            for (int i = 0; i < 10; i++)
            {
                arr1.AddLast(i);
            }
            Console.WriteLine(arr1);

            for (int i = 0; i < 20; i++)
            {
                arr1.AddLast(i);
            }
            Console.WriteLine(arr1);

            string[] a = { "q", "r", "g", "w", "e", "r", "t", "y", "u", "i", "o", "p", "u", "i", "o", "p", "q", "w", "e", "r", "t", "f", "v", "z", "n", "m" };
            Array2<string> arr2 = new Array2<string>();
            for (int i = 0; i < 10; i++)
            {
                arr2.AddLast(a[i]);
            }
            Console.WriteLine(arr2);

            for (int i = 0; i < 20; i++)
            {
                arr2.AddLast(a[i]);
            }
            Console.WriteLine(arr2);




            //测试链表LinkedList的代码

            Stopwatch t = new Stopwatch();
            t.Start();
            LinkedList<int> l = new LinkedList<int>();
            for (int i = 0; i < 1000000; i++)
            {
                l.AddFirst(i);
            }
            t.Stop();
            Console.WriteLine("运行时间：" + t.ElapsedMilliseconds + "ms");
            //l.AddLast(666);
            //Console.WriteLine(l);

            //l.Add(2, 999);
            //Console.WriteLine(l);

            //l.Set(2, 1000);
            //Console.WriteLine(l);





            //测试栈的代码

            //ArrayStack<int> arrstack = new ArrayStack<int>();

            //for (int i = 0; i < 10; i++)
            //{
            //    arrstack.Push(i);
            //    Console.WriteLine(arrstack);
            //}

            //Console.WriteLine(arrstack.Peek());
            //arrstack.Pop();
            //Console.WriteLine(arrstack);
            //arrstack.Push(100);
            //Console.WriteLine(arrstack);




            //测试
        }
    }
}
