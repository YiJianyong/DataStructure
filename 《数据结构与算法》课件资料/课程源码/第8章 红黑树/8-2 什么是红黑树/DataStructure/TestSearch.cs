using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class TestSearch
    {
        //读取名为filename的文件并将数据存储到数组中返回
        public static int[] ReadFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            List<int> list = new List<int>();

            while (!sr.EndOfStream)
            {
                int num = int.Parse(sr.ReadLine());
                list.Add(num);
            }

            fs.Close();
            sr.Close();

            return list.ToArray();
        }

        //顺序查找法
        public static int OrderSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == target)
                    return i;

            return -1;
        }

        //二分查找法，在有序数组arr中，查找target
        //如果找到target，返回相应的索引index
        //如果没有找到target，返回-1
        public static int BinarySearch(int[] arr,int target)
        {
            //在[l...r]范围里寻找target
            int l = 0;
            int r = arr.Length - 1;

            while (l <= r)
            {
                //int mid = (r + l) / 2;
                int mid = l + (r - l) / 2;

                if (target < arr[mid])
                    r = mid - 1;    //在arr[l...mid-1]查找target
                else if (target > arr[mid])
                    l = mid + 1;    //在arr[mid+1...r]查找target
                else
                    return mid;     //找到target，并返回索引
            }

            return -1;
        }
    }
}
