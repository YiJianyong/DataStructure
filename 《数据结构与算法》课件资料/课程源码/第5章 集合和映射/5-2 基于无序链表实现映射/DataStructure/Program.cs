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

            Console.WriteLine("双城记");
            List<string> words=TestHelper.ReadFile("测试文件1/双城记.txt");
            Console.WriteLine("总单词数： "+words.Count);

            Stopwatch t = new Stopwatch();

            LinkedList3Dictionary<string, int> dic = new LinkedList3Dictionary<string, int>();
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

            Console.WriteLine("不同的单词总数： "+dic.Count);
            Console.WriteLine("city出现的频次： "+dic.Get("city"));
            Console.WriteLine("运行时间： "+t.ElapsedMilliseconds+"ms");


            Console.Read();
        }
    }
}
