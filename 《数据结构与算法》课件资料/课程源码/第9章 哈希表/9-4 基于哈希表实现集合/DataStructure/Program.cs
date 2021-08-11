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

            Console.WriteLine("双城记");

            List<string> words = TestHelper.ReadFile("测试文件1/双城记.txt");
            Console.WriteLine("词汇量总数：" + words.Count);

            Console.WriteLine();

            Console.WriteLine("(基于红黑树实现)集合");
            RBT1Set<string> rbt1Set = new RBT1Set<string>();
            long t1 = TestSet(rbt1Set, words);
            Console.WriteLine("不同单词的总数： " + rbt1Set.Count);
            Console.WriteLine("运行时间： " + t1 + "ms");

            Console.WriteLine();

            Console.WriteLine("(基于哈希表实现)集合");
            HashST1Set<string> hashST1Set = new HashST1Set<string>(997);
            long t2 = TestSet(hashST1Set, words);
            Console.WriteLine("不同单词的总数： " + hashST1Set.Count);
            Console.WriteLine("运行时间： " + t2 + "ms");

            Console.WriteLine();

            Console.WriteLine("C#自带的集合");
            HashSet<string> set = new HashSet<string>();
            Stopwatch t = new Stopwatch();
            t.Start();
            foreach (string word in words)
                set.Add(word);
            t.Stop();
            Console.WriteLine("不同单词的总数： " + set.Count);
            Console.WriteLine("运行时间： " + t.ElapsedMilliseconds + "ms");



            Console.Read();
        }

    }
}
