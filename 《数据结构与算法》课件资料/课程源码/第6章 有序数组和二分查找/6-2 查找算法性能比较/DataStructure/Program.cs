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

            //string filename1 = "测试文件2/超市会员表.txt";
            //string filename2 = "测试文件2/超市客户表.txt";

            //int[] arr1 = TestSearch.ReadFile(filename1);
            //int[] arr2 = TestSearch.ReadFile(filename2);
            //Console.WriteLine("超市会员数量 :" + arr1.Length);
            //Console.WriteLine("调查客户数量 :" + arr2.Length);

            //Console.WriteLine();

            //Stopwatch t1 = new Stopwatch();
            //Stopwatch t2 = new Stopwatch();

            //Console.WriteLine("顺序查找法");
            //t1.Start();
            //int sum1 = 0;   //记录普通客户数量
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    int target = arr2[i];
            //    if (TestSearch.OrderSearch(arr1, target) == -1)
            //    {
            //        Console.WriteLine(target);
            //        sum1++;
            //    }
            //}
            //t1.Stop();
            //Console.WriteLine("查找到" + sum1 + "个普通客户");
            //Console.WriteLine("运行时间: " + t1.ElapsedMilliseconds + "ms");

            //Console.WriteLine();

            //Console.WriteLine("二分查找法");
            //t2.Start();
            //Array.Sort(arr1); //调用C#自带的排序方法对数组进行排序，才可以使用二分查找法
            //int sum2 = 0;
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    int target = arr2[i];
            //    if (TestSearch.BinarySearch(arr1, target) == -1)
            //    {
            //        Console.WriteLine(target);
            //        sum2++;
            //    }
            //}
            //t2.Stop();
            //Console.WriteLine("查找到" + sum2 + "个普通客户");
            //Console.WriteLine("运行时间: " + t2.ElapsedMilliseconds + "ms");

            string filename3 = "测试文件2/游戏会员表.txt";
            string filename4 = "测试文件2/游戏用户表.txt";

            int[] arr3 = TestSearch.ReadFile(filename3);
            int[] arr4 = TestSearch.ReadFile(filename4);
            Console.WriteLine("游戏会员数量 :" + arr3.Length);
            Console.WriteLine("调查用户数量 :" + arr4.Length);

            Console.WriteLine();

            Stopwatch t3 = new Stopwatch();
            Stopwatch t4 = new Stopwatch();

            //Console.WriteLine("顺序查找法");
            //t3.Start();
            //int sum3 = 0;
            //for (int i = 0; i < arr4.Length; i++)
            //{
            //    int target = arr4[i];
            //    if (TestSearch.OrderSearch(arr3, target) == -1)
            //    {
            //        //Console.WriteLine(target);
            //        sum3++;
            //    }
            //}
            //t3.Stop();
            //Console.WriteLine("查找到 :" + sum3 + "个零充玩家");
            //Console.WriteLine("运行时间: " + t3.ElapsedMilliseconds + "ms");

            Console.WriteLine();

            Console.WriteLine("二分查找法");
            t4.Start();
            Array.Sort(arr3);
            int sum4 = 0;
            for (int i = 0; i < arr4.Length; i++)
            {
                int target = arr4[i];
                if (TestSearch.BinarySearch(arr3, target) == -1)
                {
                    //Console.WriteLine(target);
                    sum4++;
                }
            }
            t4.Stop();
            Console.WriteLine("查找到 :" + sum4 + "个零充玩家");
            Console.WriteLine("运行时间: " + t4.ElapsedMilliseconds + "ms");


            Console.Read();

        }
    }
}
