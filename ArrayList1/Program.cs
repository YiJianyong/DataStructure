using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1
{
    class Program
    {
        static void Main(string[] args)
        {
            BST1<int> bst = new BST1<int>();
            int[] arr = { 56, 2, 5, 67, 8, 34, 12, 35, 24, 17, 89, 90, 67, 49, 60 };
            for (int i = 0; i < arr.Length; i++)
            {
                bst.Add(arr[i]);
            }
            bst.InOrder();
            bst.LevelOrder();

            Console.Read();

        }
    }
}
