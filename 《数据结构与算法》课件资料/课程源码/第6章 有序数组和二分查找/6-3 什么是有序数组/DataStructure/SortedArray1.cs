using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    //有序数组
    //存储的元素必须是可比较的。这样才能进行排序。
    //数据类型Key必须是实现了可比较的接口IComparable<Key>，才能进行元素的存储。
    //where Key:IComparable<Key> 对Key进行泛型约束，限定Key类型，不能是任意类型
    class SortedArray1<Key> where Key:IComparable<Key>
    {
        private Key[] keys;
        private int N;

        public SortedArray1(int capacity)
        {
            keys = new Key[capacity];
        }

        public SortedArray1() : this(10) { }

        public int Count { get { return N; } }

        public bool IsEmpty { get { return N == 0; } }

        //排名。返回有序数组中小于key的键的数量
        public int Rank(Key key)
        {
            //在[l...r]范围里寻找key
            int l = 0;
            int r = N - 1;

            while (l <= r)
            {
                //int mid = (r + l) / 2;
                int mid = l + (r - l) / 2;

                //对于IComparable接口中的 int CompareTo（Key key）方法。会返回1,-1, 0.其中的一个整数
                //如果a.CompareTo（b)=1 > 0    说明 a > b
                //如果a.CompareTo（b)=-1 < 0   说明 a < b
                //如果a.CompareTo（b)=0 == 0   说明 a==b

                if (key.CompareTo(keys[mid]) < 0)
                    r = mid - 1;    //在keys[l...mid-1]查找key
                else if (key.CompareTo(keys[mid]) > 0)
                    l = mid + 1;    //在keys[mid+1...r]查找key
                else    //key.CompareTo(keys[mid]) == 0
                    return mid;     //找到key，并返回索引
            }

            return l;
        }
    }
}
