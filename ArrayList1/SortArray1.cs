using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1
{
    //where T:IComparable<T> 对T进行泛型约束，限定T类型，不能是任意类型
    class SortArray1<T> where T:IComparable<T>
    {
        //有序数组
        //存储的元素必须是可比较的元素，才可排序
        private T[] key;
        private int N;

        public SortArray1(int capacity)
        {
            key = new T[capacity];
        }

        public SortArray1(): this(10){ }

        //常用属性
        public int Count { get { return N; } }

        public bool IsEmpty { get { return N == 0; } }

        public int Rank(T e)
        {
            int left = 0;
            int right = N - 1;

            while (left <= right)
            {
                //利用二分查找寻找该元素在数组的索引位置
                //防止(r + l)整型溢出 故用下面的减法代替加法
                //int mid = (r + l) / 2;
                int mid = left + (right - left) / 2;

                if (e.CompareTo(key[mid]) < 0)
                    right = mid - 1;    //在key[l...mid-1]查找e
                else if (e.CompareTo(key[mid]) > 0)
                    left = mid + 1;    //在key[mid+1...r]查找e
                else    //e.CompareTo(key[mid]) == 0
                    return mid;     //找到e，并返回索引
            }

            return left;
        }



    }
}
