using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    //第一版数组类
    class Array1<E>
    {
        private E[] data;   //存储元素的数组
        private int N;      //数组中的元素个数

        //通过指定容量开辟数组空间
        public Array1(int capacity)
        {
            data = new E[capacity];
            N = 0;
        }

        //默认数组容量为10
        public Array1() : this(10) { }

        //获取数组容量的属性
        public int Capacity
        {
            get { return data.Length; }
        }

        //获取数组元素个数的属性
        public int Count
        {
            get { return N; }
        }

        //判断数组是否为空的属性
        public bool IsEmpty
        {
            get { return N == 0; }
        }

        //在数组指定位置添加元素e
        public void Add(int index, E e)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");

            if (N == data.Length)
                ResetCapacity(2 * data.Length);

            for (int i = N - 1; i >= index; i--)
                data[i + 1] = data[i];

            data[index] = e;
            N++;
        }

        //在数组尾部添加元素e
        public void AddLast(E e)
        {
            Add(N, e);
        }

        //在数组头部添加元素e
        public void AddFirst(E e)
        {
            Add(0, e);
        }

        //获取指定位置的元素e
        public E Get(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("数组索引越界");

            return data[index];
        }

        //获取数组头部的元素e
        public E GetFirst()
        {
            return Get(0);
        }

        //获取数组尾部的元素e
        public E GetLast()
        {
            return Get(N - 1);
        }

        //修改数组中的值
        public void Set(int index, E newE)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("数组索引越界");

            data[index] = newE;
        }

        //查询数组是否包含元素e
        public bool Contains(int e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals(e))
                    return true;
            }

            return false;
        }

        //查询数组中元素e的位置索引
        public int IndexOf(int e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals(e))
                    return i;
            }

            return -1;
        }

        //删除指定位置的元素并返回该元素
        public E RemoveAt(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("索引超出了数组界限");

            E del = data[index];

            for (int i = index + 1; i <= N - 1; i++)
                data[i - 1] = data[i];

            N--;
            data[N] = default(E);

            if (N == data.Length / 4)
                ResetCapacity(data.Length / 2);

            return del;
        }

        //删除数组头部位置的元素并返回该元素
        public E RemoveFirst()
        {
            return RemoveAt(0);
        }

        //删除数组尾部位置的元素并返回该元素
        public E RemoveLast()
        {
            return RemoveAt(N - 1);
        }

        //删除指定的元素e
        public void Remove(int e)
        {
            int index = IndexOf(e);
            if (index != -1)
                RemoveAt(index);
        }

        //调整数组容量的大小
        private void ResetCapacity(int newCapacity)
        {
            E[] newData = new E[newCapacity];
            for (int i = 0; i < N; i++)
                newData[i] = data[i];

            data = newData;
        }

        //输出数组类的信息
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            //res.Append(string.Format("Array1:  count={0}  capacity={1}\n", N, data.Length));
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
