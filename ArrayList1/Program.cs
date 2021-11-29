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
        public static void InsertSort(Array2<int> seqList)//[o(n),o(n^2)]
        {
            for (int i = 1; i < seqList.Count; ++i)
            {
                if (seqList.Get(i) < seqList.Get(i - 1)
                {
                    int temp = seqList.Get(i);
                    int j = 0;
                    for (j = i - 1; j >= 0 && temp < seqList.Get(j); --j)
                    {
                        seqList. = seqList.Get(j);//make place
                    }
                    seqList.Get(j + 1) = temp;
                }
            }
        }
    }
}
