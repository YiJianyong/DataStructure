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
            Array1 a = new Array1(10);

            for (int i = 0; i < 10; i++)
                a.AddLast(i);

            Console.WriteLine(a);

            a.AddLast(55);
            Console.WriteLine(a);

            for (int i = 0; i < 6; i++)
            {
                a.RemoveLast();
                Console.WriteLine(a);
            }

            Console.Read();
        }
    }
}
