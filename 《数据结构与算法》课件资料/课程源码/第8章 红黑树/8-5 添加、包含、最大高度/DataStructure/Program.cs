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
            RBT1<int> rbt = new RBT1<int>();
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < a.Length; i++)
                rbt.Add(a[i]);

            Console.WriteLine(rbt.MaxHeight());


            Console.Read();
        }
    }
}
