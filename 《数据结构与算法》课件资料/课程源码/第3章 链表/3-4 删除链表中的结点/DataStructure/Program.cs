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
            LinkedList1<int> l = new LinkedList1<int>();
            for (int i = 0; i < 5; i++)
            {
                l.AddFirst(i);
                Console.WriteLine(l);
            }

            l.AddLast(666);
            Console.WriteLine(l);

            l.Add(2, 999);
            Console.WriteLine(l);

            l.Set(2, 1000);
            Console.WriteLine(l);

            //4->3->1000->2->1->0->666->Null

            l.RemoveAt(2);
            Console.WriteLine(l);

            l.RemoveFirst();
            Console.WriteLine(l);

            l.RemoveLast();
            Console.WriteLine(l);

            l.Remove(0);
            Console.WriteLine(l);

            

            Console.Read();
        }
    }
}
