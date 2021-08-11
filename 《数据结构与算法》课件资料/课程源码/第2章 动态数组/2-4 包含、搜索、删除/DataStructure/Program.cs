using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Array1 a = new Array1(20);

            for (int i = 0; i < 10; i++)
                a.AddLast(i);

            Console.WriteLine(a);

            a.AddFirst(66);
            Console.WriteLine(a);

            a.Add(2, 77);
            Console.WriteLine(a);

            //[66, 0, 77, 1, 2, 3, 4, 5, 6, 7, 8, 9]

            a.RemoveAt(2);
            a.RemoveFirst();
            a.RemoveLast();
            a.Remove(4);
            Console.WriteLine(a);

            Console.Read();
        }
    }
}
