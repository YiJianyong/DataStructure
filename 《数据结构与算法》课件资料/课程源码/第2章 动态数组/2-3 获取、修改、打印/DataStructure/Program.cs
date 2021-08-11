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
            {
                a.AddLast(i);
            }

            Console.WriteLine(a);

            a.AddFirst(66);
            Console.WriteLine(a);

            a.Add(2, 77);
            Console.WriteLine(a);

            Console.WriteLine(a.GetFirst());
            Console.WriteLine(a.GetLast());
            Console.WriteLine(a.Get(1));

            a.Set(1, 1000);
            Console.WriteLine(a);


            Console.Read();
        }
    }
}
