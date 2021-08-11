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
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = i;
                Console.Write(arr[i]+" ");
            }

            Console.WriteLine();

            ArrayList a = new ArrayList(10);
            for (int i = 0; i < 15; i++)
            {
                a.Add(i);
                Console.Write(a[i]+" ");
            }

            Console.WriteLine();

            List<int> l = new List<int>(10);
            for (int i = 0; i < 15; i++)
            {
                l.Add(i);
                Console.Write(l[i]+" ");
            }

            Console.Read();
        }
    }
}
