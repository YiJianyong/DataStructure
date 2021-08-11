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

        public  int Rank(Key key)
        {
            //在[l...r]范围里寻找key
            int l = 0;
            int r = N - 1;

            while (l <= r)
            {
                //int mid = (r + l) / 2;
                int mid = l + (r - l) / 2;

                if (key.CompareTo(keys[mid]) < 0)
                    r = mid - 1;    //在keys[l...mid-1]查找key
                else if (key.CompareTo(keys[mid]) > 0)
                    l = mid + 1;    //在keys[mid+1...r]查找key
                else    //key.CompareTo(keys[mid]) == 0
                    return mid;     //找到key，并返回索引
            }

            return l;
        }

        //添加键（不允许添加重复键）
        public void Add(Key key)
        {
            //找到合适的添加位置i
            int i = Rank(key); 

            //支持动态调整数组大小的能力
            if (N == keys.Length)   
                ResetCapacity(2 * keys.Length);

            //如果要添加的键在数组中已经存在 结束Add方法什么都不用干
            //i < N 保证 keys[i] 是合法的 避免在未命中查找的情况产生数组越界
            if ( i < N && keys[i].CompareTo(key) == 0)
                return;

            //元素复制移动把 i 这个位置腾出来放key
            //这个操作和我们以前学过的往动态数组的某个位置index添加是一样的。
            //不熟悉的话可以倒回去回顾 ：）
            for (int j = N-1; j >= i; j--)
                keys[j + 1] = keys[j];

            keys[i] = key;
            N++;
        }

        //删除键
        public void Remove(Key key)
        {
            //数组为空，没得可删除直接结束Remove方法
            if (IsEmpty)
                return;

            //计算出要删除key的位置 i
            int i = Rank(key);

            //如果i==N索引不合法 或者 要删除的key在数组中不存在 没得可删除直接结束Remove方法
            if (i==N || keys[i].CompareTo(key) != 0)
                return;

            //元素复制移动把 i 这个位置对应的元素覆盖掉。将它删除
            //这个操作和我们以前学过的在动态数组中删除index位置的元素是一样的。
            //不熟悉的话可以倒回去回顾 ：）
            for (int j = i+1; j <= N-1; j++)
                keys[j - 1] = keys[j];

            N--;
            keys[N] = default(Key);

            //缩容操作释放空间
            if (N == keys.Length / 4)
                ResetCapacity(keys.Length / 2);
        }

        //调整数组容量的大小
        private void ResetCapacity(int newCapacity)
        {
            Key[] newKeys = new Key[newCapacity];
            for (int i = 0; i < N; i++)
                newKeys[i] = keys[i];

            keys = newKeys;
        }

        //输出数组类的信息
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append(keys[i]);
                if (i != N - 1)
                    res.Append(", ");
            }
            res.Append("]");
            return res.ToString();
        }
    }
}
