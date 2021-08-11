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
        private static long TestSet(ISet<string> set, List<string> words)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            foreach (string word in words)
                set.Add(word);
            t.Stop();
            return t.ElapsedMilliseconds;
        }

        static void Main(string[] args)
        {

            //Console.WriteLine("双城记");

            //List<string> words = TestHelper.ReadFile("测试文件1/双城记.txt");
            //Console.WriteLine("词汇量总数：" + words.Count);

            //Console.WriteLine();

            //Console.WriteLine("(基于二叉查找树实现)集合");
            //BST1Set<string> bst1Set = new BST1Set<string>();
            //long t1 = TestSet(bst1Set, words);
            //Console.WriteLine("不同单词的总数： " + bst1Set.Count);
            //Console.WriteLine("运行时间： " + t1 + "ms");
            //Console.WriteLine("树的最大高度： " + bst1Set.MaxHeight());

            //Console.WriteLine();

            //Console.WriteLine("(基于有序数组实现)集合");
            //SortedArray1Set<string> sortedArray1Set = new SortedArray1Set<string>();
            //long t2 = TestSet(sortedArray1Set, words);
            //Console.WriteLine("不同单词的总数： " + sortedArray1Set.Count);
            //Console.WriteLine("运行时间： " + t2 + "ms");

            //对于随机性非常强的测试用例，二叉树的性能非常的好，因为树的高度很矮
            //但是对于有序性非常强（顺序或逆序）的用例呢，二叉树的性能就会变得非常的差，显然是不能接受的
            //因为树的高度会非常的高。我们递归的添加呢，有可能会出现栈溢出的情况。
            //这就是我们需要寻找更好的算法和数据结构的原因，我们会在下一章学习：）

            Random r = new Random();
            //r.Next() [0,2147483647)
            Stopwatch t = new Stopwatch();
            t.Start();
            BST1Set<int> set = new BST1Set<int>();
            for (int i = 0; i < 2000000; i++)
                set.Add(r.Next());
            t.Stop();
            Console.WriteLine("运行时间： " + t.ElapsedMilliseconds + "ms");
            Console.WriteLine("树的最大高度： " + set.MaxHeight());


            Console.Read();
        }
    }
}
