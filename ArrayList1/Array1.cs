using System;
using System.Text;

namespace DataStructure1
{
    //第一版数组：简单实现，仅支持int类型的数组
    class Array1
    {
        private int[] data;
        private int N; //数组中存储的元素个数

        //构造函数
        public Array1(int capacity)
        {
            data = new int[capacity];
            N = 0;
        }

        //无参数(默认10个元素)构造函数
        public Array1() : this(10) { }

        public int Capacity
        {
            get { return data.Length; }
        }

        public int Count
        {
            get { return N; }
        }

        public bool IsEmpty
        {
            get { return N == 0; }
        }

        //指定索引处的元素添加
        public void Add(int index, int e)
        {
            //检查边界，防止出现越界
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");

            //判断是否进行扩容操作
            if (N == data.Length)
                ResetCapacity(2 * data.Length);

            //将index索引处以后的元素依次后移一位
            for (int i = N - 1; i >= index; i--)
                data[i + 1] = data[i];

            data[index] = e;
            N++;
        }

        public void AddLast(int e)
        {
            Add(N, e);
        }

        public void AddFirst(int e)
        {
            Add(0, e);
        }

        //获取指定索引处的元素值
        public int Get(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("数组索引越界");

            return data[index];
        }

        public int GetFirst()
        {
            return Get(0);
        }

        public int GetLast()
        {
            return Get(N - 1);
        }


        public void Set(int index, int newE)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("数组索引越界");

            data[index] = newE;
        }

        //判断数组中是否存在该值
        public bool Contains(int e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i] == e)
                    return true;
            }

            return false;
        }

        //返回指定元素的索引值，不存在该元素返回-1
        public int IndexOf(int e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i] == e)
                    return i;
            }
            return -1;
        }

        //删除指定索引处的元素，并且返回被删除的元素
        public int RemoveAt(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("索引超出了数组界限");

            int del = data[index];

            for (int i = index + 1; i <= N - 1; i++)
                data[i - 1] = data[i];

            N--;
            data[N] = default(int);
            //判断是否需要进行缩容操作
            if (N == data.Length / 4)
                ResetCapacity(data.Length / 2);

            return del;
        }

        public int RemoveFirst()
        {
            return RemoveAt(0);
        }

        public int RemoveLast()
        {
            return RemoveAt(N - 1);
        }

        //删除指定元素
        public void Remove(int e)
        {
            int index = IndexOf(e);
            if (index != -1)
                RemoveAt(index);
        }


        //修改数组容量
        private void ResetCapacity(int newCapacity)
        {
            int[] newData = new int[newCapacity];
            //依次将原数组中的元素拷贝到新容量数组中
            for (int i = 0; i < N; i++)
                newData[i] = data[i];

            data = newData;
        }

        //重写一下ToString()函数
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(string.Format("Array1:  count={0}  capacity={1}\n", N, data.Length));
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append(data[i]);
                if (i != N - 1)
                    res.Append(", ");
            }
            res.Append("]");
            return res.ToString();
        }
    }
}