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

            Array1Queue<int> array1Queue = new Array1Queue<int>();
            for (int i = 0; i < 5; i++)
            {
                array1Queue.Enqueue(i);
                Console.WriteLine(array1Queue);
            }

            array1Queue.Dequeue();
            Console.WriteLine(array1Queue);


            Console.Read();
        }
    }
}
