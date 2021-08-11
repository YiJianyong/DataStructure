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
        public static long TestDictionary(IDictionary<string, int> dic, List<string> words)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            foreach (var word in words)
            {
                //如果单词不存在字典中，说明是第一次遇见这个单词，频次设为1
                if (!dic.ContainsKey(word))
                    dic.Add(word, 1);
                else  //如果单词已经存在在字典中，将单词对应的频次+1
                    dic.Set(word, dic.Get(word) + 1);
            }
            t.Stop();
            return t.ElapsedMilliseconds;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("双城记");

            List<string> words = TestHelper.ReadFile("测试文件1/双城记.txt");
            Console.WriteLine("词汇量总数：" + words.Count);

            Console.WriteLine();

            Console.WriteLine("（基于二叉查找树实现）字典");
            BST2Dictionary<string, int> dic1 = new BST2Dictionary<string, int>();
            long t1 = TestDictionary(dic1, words);
            Console.WriteLine("不同的单词总数： " + dic1.Count);
            Console.WriteLine("city出现的频次： " + dic1.Get("city"));
            Console.WriteLine("运行时间： " + t1 + "ms");

            Console.WriteLine();

            Console.WriteLine("（基于红黑树实现）字典");
            RBT2Dictionary<string, int> dic2 = new RBT2Dictionary<string, int>();
            long t2 = TestDictionary(dic2, words);
            Console.WriteLine("不同的单词总数： " + dic2.Count);
            Console.WriteLine("city出现的频次： " + dic2.Get("city"));
            Console.WriteLine("运行时间： " + t2 + "ms");


            Console.WriteLine("C#中自带的红黑树字典");
            SortedDictionary<string, int> dic = new SortedDictionary<string, int>();

            Console.Read();
        }

    }
}
