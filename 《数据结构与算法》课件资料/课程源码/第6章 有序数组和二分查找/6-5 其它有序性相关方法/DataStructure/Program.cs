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
            //int类型实现了接口IComparable<Int32> 它是一个可比较的数据类型
            int[] arr = { 84, 48, 68, 10, 18, 98, 12, 23, 54, 57, 33, 16, 77, 11, 29 };

            SortedArray1<int> sortedArray1 = new SortedArray1<int>();
            for (int i = 0; i < arr.Length; i++)
                sortedArray1.Add(arr[i]);

            Console.WriteLine(sortedArray1);
            Console.WriteLine(sortedArray1.Min());
            Console.WriteLine(sortedArray1.Max());
            Console.WriteLine(sortedArray1.Select(5));
            Console.WriteLine(sortedArray1.Floor(15));
            Console.WriteLine(sortedArray1.Ceiling(15));
            sortedArray1.Remove(23);
            Console.WriteLine(sortedArray1);

            //使用有序数组存储我们自定义的Student类型
            Student[] students =
            {
                new Student("小明",180),
                new Student("小红",150),
                new Student("小芳",175),
                new Student("小华",160),
                new Student("小李",190),
            };

            SortedArray1<Student> s = new SortedArray1<Student>();

            for (int i = 0; i < students.Length; i++)
                s.Add(students[i]);

            Console.WriteLine(s);

            Console.Read();

        }
    }
}
