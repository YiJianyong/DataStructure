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

            //Console.WriteLine("(基于红黑树实现)集合");
            //RBT1Set<string> rbt1Set = new RBT1Set<string>();
            //long t2 = TestSet(rbt1Set, words);
            //Console.WriteLine("不同单词的总数： " + rbt1Set.Count);
            //Console.WriteLine("运行时间： " + t2 + "ms");
            //Console.WriteLine("树的最大高度： " + rbt1Set.MaxHeight());


            //Stopwatch t = new Stopwatch();
            //t.Start();
            //RBT1Set<int> set = new RBT1Set<int>();
            //for (int i = 0; i < 10000000; i++)
            //    set.Add(i);
            //t.Stop();
            //Console.WriteLine("运行时间： " + t.ElapsedMilliseconds + "ms");
            //Console.WriteLine("树的最大高度： " + set.MaxHeight());


            Console.WriteLine("C#自带的红黑树集合");
            SortedSet<int> set = new SortedSet<int>();


            Console.Read();
        }

    }
}
