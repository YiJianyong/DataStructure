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

            Array2Queue<int> array2Queue = new Array2Queue<int>();
            for (int i = 0; i < 5; i++)
            {
                array2Queue.Enqueue(i);
                Console.WriteLine(array2Queue);
            }

            array2Queue.Dequeue();
            Console.WriteLine(array2Queue);


            Console.Read();
        }
    }
}
