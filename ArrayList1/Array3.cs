using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1
{
    class Array3<T>
    {
        //具有头尾索引的循环数组
        private T[] data;
        private int first;
        private int last;
        private int N;


        //构造函数:传入容量参数capacity
        public Array3(int capacity)
        {
            data = new T[capacity];
            first = 0;
            last = 0;
            N = 0;
        }

        //构造函数:默认capacity = 10
        public Array3() : this(10) { }

        //Count属性、IsEmpty属性
        public int Count
        {
            get { return N; }
        }
        public bool IsEmpty
        {
            get { return N == 0; }
        }

        public void AddLast(T e)
        {
            //判断是否需要扩容
            if (N == data.Length)
                ResetCapacity(2 * data.Length);
            data[last] = e;
            last = (last + 1) % data.Length;
            N++;
        }

        public T RemoveFirst()
        {
            //判断数组是否为空
            if (IsEmpty)
                throw new InvalidOperationException("数组为空");

            //用一个变量记录被删除的元素
            T del = data[first];
            data[first] = default(T);//释放空间
            //更新first的值
            first = (first + 1) % data.Length;
            N--;

            //判断是否需要执行缩容
            if (N <= data.Length / 4)
                ResetCapacity(data.Length / 2);
            return del;//返回被删除的元素
        }

        public T GetFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException("数组为空");

            return data[first];
        }

        private void ResetCapacity(int newCapacity)
        {
            T[] newData = new T[newCapacity];

            //将原数组中的参数按顺序依次拷贝到新数组中
            for(int i = 0; i < N; i++)
            {
                //将原数组索引转换成新数组中的索引
                newData[i] = data[(first + i) % data.Length];
            }
            //更新下标的值
            data = newData;
            first = 0;
            last = N - 1;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("[");
            for (int i = 0; i < N; i++)
            {
                str.Append(data[(first + i) % data.Length]);
                if ((first + i) % data.Length != last)
                    str.Append(",");
            }
            str.Append("]");
            return str.ToString();

        }


    }
}
