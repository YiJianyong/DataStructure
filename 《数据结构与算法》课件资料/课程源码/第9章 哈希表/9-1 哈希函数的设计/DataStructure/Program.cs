using System;
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

            int a = 123;
            Console.WriteLine(a.GetHashCode());

            int b = -123;
            Console.WriteLine(b.GetHashCode());

            float c = 0.5f;
            Console.WriteLine(c.GetHashCode());

            string d = "abc";
            Console.WriteLine(d.GetHashCode());


            Console.Read();
        }

    }
}
