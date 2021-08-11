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

            int[] a = { 8, 4, 12, 2, 6, 10, 14 };

            ///////////////////////
            //         8         //
            //     /       \     //
            //    4        12    //
            //  /   \     /   \  //
            // 2     6   10   14 //
            ///////////////////////

            BST1<int> bst = new BST1<int>();

            for (int i = 0; i < a.Length; i++)
                bst.Add(a[i]);

            Console.WriteLine(bst.MaxHeight());


            Console.Read();
        }
    }
}
