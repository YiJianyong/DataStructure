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
        
        public static long TestSet(ISet<string> set,List<string> words)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            foreach (var word in words)
                set.Add(word);
            t.Stop();
            return t.ElapsedMilliseconds;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("双城记");

            List<string> words=TestHelper.ReadFile("测试文件1/双城记.txt");
            Console.WriteLine("词汇量总数："+words.Count);

            Console.WriteLine();

            Console.WriteLine("链表集合");
            LinkedList1Set<string> linkedList1Set = new LinkedList1Set<string>();
            long t1=TestSet(linkedList1Set, words);
            Console.WriteLine("不同单词的总数： "+linkedList1Set.Count);
            Console.WriteLine("运行时间： "+t1+"ms");

            Console.WriteLine();

            Console.WriteLine("有序数组集合");
            SortedArray1Set<string> sortedArray1Set = new SortedArray1Set<string>();
            long t2 = TestSet(sortedArray1Set, words);
            Console.WriteLine("不同单词的总数： " + sortedArray1Set.Count);
            Console.WriteLine("运行时间： " + t2 + "ms");

            //对于（基于有序数组）实现的集合SortedArray1Set
            //它在查找集合中是否包含有指定键非常快速 O（log n）
            //如果要添加的键就在集合中，找到后会直接return结束Add方法。不需要添加。O（log n）
            //如果要添加的键就不在集合中，为了保持集合的有序性：
            //需要在数组中指定的位置添加。发生元素的移动。如果数据规模n越大，需要移动的元素越多。O（n）
            //所以说添加方法太慢了。如果说我们存储的数据是只涉及到查询。在初始化的时候，花点时间排序是值得的。
            //如果我需要不断地对集合进行添加或删除操作。很明显，它是无法处理大型问题的。
            //在下一章中我们会对集合进行改进，使它添加、删除、查询都达到 O（log n）：）

            //补充：C#并没有提供（基于有序数组）实现的有序集合
            //对于C#提供的有序集合（SortedSet） 它是基于红黑树实现的。
            //在课程的后续，讲到红黑树时，我们会实现一个（基于红黑树）的有序集合 :)
            Console.WriteLine("C#中的有序集合");
            SortedSet<string> set = new SortedSet<string>();

            Console.Read();

        }
    }
}
