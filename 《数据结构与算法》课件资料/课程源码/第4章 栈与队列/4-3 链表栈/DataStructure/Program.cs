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

            LinkedList1Stack<int> stack = new LinkedList1Stack<int>();
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
                Console.WriteLine(stack);
            }

            stack.Pop();
            Console.WriteLine(stack);

            Console.Read();
        }
    }
}
