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
            Stopwatch t = new Stopwatch();

            Console.WriteLine("双城记");

            List<string> words=TestHelper.ReadFile("测试文件1/双城记.txt");
            Console.WriteLine("总单词数： "+words.Count);

            LinkedList1Set<string> set = new LinkedList1Set<string>();

            t.Start();
            foreach (var word in words)
                set.Add(word); //添加的过程中会进行去重的操作，不允许添加重复元素
            t.Stop();

            Console.WriteLine("不同单词的总数： "+set.Count);
            Console.WriteLine("运行时间： "+t.ElapsedMilliseconds);

            Console.Read();
        }
    }
}
