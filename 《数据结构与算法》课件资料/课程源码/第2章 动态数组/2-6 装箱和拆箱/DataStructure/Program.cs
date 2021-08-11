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
        //List和ArrayList性能测试
        static void Main(string[] args)
        {

            int n = 10000000;

            Stopwatch t1 = new Stopwatch();
            Stopwatch t2 = new Stopwatch();
            Stopwatch t3 = new Stopwatch();
            Stopwatch t4 = new Stopwatch();

            Console.WriteLine("测试值类型对象int");
            t1.Start();
            List<int> l = new List<int>();
            for (int i = 0; i < n; i++)
            {
                l.Add(i);   //不发生装箱
                int x=l[i]; //不发生拆箱
            }
            t1.Stop();
            Console.WriteLine("List'time: "+t1.ElapsedMilliseconds+"ms");

            t2.Start();
            ArrayList a = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                a.Add(i);        //发生装箱
                int x=(int)a[i]; //发生拆箱
            }
            t2.Stop();
            Console.WriteLine("ArrayList'time: " + t2.ElapsedMilliseconds + "ms");

            Console.WriteLine("测试引用类型对象string");
            t3.Start();
            List<string> l2 = new List<string>();
            for (int i = 0; i < n; i++)
            {
                l2.Add("X");       //不发生装箱
                string x = l2[i];  //不发生拆箱
            }
            t3.Stop();
            Console.WriteLine("List'time: " + t3.ElapsedMilliseconds + "ms");

            t4.Start();
            ArrayList a2 = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                a2.Add("X");              //不发生装箱
                string x = (string)a2[i]; //不发生拆箱
            }
            t4.Stop();
            Console.WriteLine("ArrayList'time: " + t4.ElapsedMilliseconds + "ms");

            Console.Read();
        }
    }
}
