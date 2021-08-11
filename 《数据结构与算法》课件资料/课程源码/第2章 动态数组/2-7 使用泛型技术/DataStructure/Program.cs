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
     
   
        static void Main(string[] args)
        {
            //测试泛型数组存储任意类型的数据

            int[] n = { 1, 2, 3, 4, 5, 6, 7 };
            Array1<int> a = new Array1<int>();
            for (int i = 0; i < n.Length; i++)
                a.AddLast(n[i]);
            Console.WriteLine(a);

            string[] s = { "a", "b", "c", "d" };
            Array1<string> a2 = new Array1<string>();
            for (int i = 0; i < s.Length; i++)
                a2.AddLast(s[i]);
            Console.WriteLine(a2);


            Console.Read();
        }
    }
}
