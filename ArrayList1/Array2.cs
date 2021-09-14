using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1
{
    //支持泛型的动态数组(有自动缩容和扩容功能：还是存在一定空间浪费，故引入下一节的链表)
    class Array2<T>
    {
        private T[] data;   //存储元素的数组
        private int N;      //数组中的元素个数

        //通过指定容量开辟数组空间
        public Array2(int capacity)
        {
            data = new T[capacity];
            N = 0;
        }

        //无参构造函数(默认数组大小为10)
        public Array2() : this(10) { }

        //获取数组的容量属性
        public int Capacity
        {
            get { return data.Length; }
        }

        //获取数组元素个数多少的属性
        public int Count
        {
            get { return N; }
        }

        //判断数组是否为空的属性
        public bool IsEmpty
        {
            get { return N == 0; }
        }

        //在指定索引处添加元素
        public void Add (int index, T e)
        {
            if (index < 0 || index > N)//调用AddLast()函数时index = N
            {
                throw new ArgumentException("数组索引越界");
            }

            //判断是否进行扩容操作
            if (N == data.Length)
                ResetCapacity(2 * data.Length);

            for (int i = N -1;i >= index; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = e;
            N++;
        }

        public void AddLast(T e)
        {
            Add(N, e);
        }

        public void AddFirst(T e)
        {
            Add(0, e);
        }

        public T Get(int index)
        {
            if(index < 0 || index >= N)
            {
                throw new ArgumentException("数组索引越界");
            }

            return data[index];
        }

        public T GetLast()
        {
            return Get(N - 1);
        }

        public T GetFirst()
        {
            return Get(0);
        }


        public void Set(int index,T newE)
        {
            if (index < 0 || index >= N)
            {
                throw new ArgumentException("数组索引越界");
            }
            data[index] = newE;
        }

        public bool Contains(T e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals(e))
                {
                    return true;
                }
            }
            return false;
        }

        //查询指定元素发索引
        public int IndexOf(T e)
        {
            for (int i = 0;i < N; i++)
            {
                if (data[i].Equals(e))
                {
                    return i;
                }
            }
            return -1;
        }

        public T RemoveAt(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("索引超出了数组界限");

            T del = data[index];

            for (int i = index + 1; i <= N - 1; i++)
                data[i - 1] = data[i];

            N--;
            data[N] = default(T);

            if (N == data.Length / 4)
                ResetCapacity(data.Length / 2);

            return del;
        }
        public T RemoveLast()
        {
            return RemoveAt(N - 1);
        }

        public T RemoveFirst()
        {
            return RemoveAt(0);
        }

        public void Remove(T e)
        {
            int index = IndexOf(e);
            if (index != -1)
            {
                RemoveAt(index);
            }
        }


        public void ResetCapacity(int newCapacity)
        {
            T[] newData = new T[newCapacity];
            for (int i = 0;i < N; i++)
            {
                newData[i] = data[i];
            }
            data = newData;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Array2:  count={0}  capacity={1}\n", N, data.Length));
            sb.Append("[");
            for (int i = 0; i < N; i++)
            {
                sb.Append(data[i]);
                if (i != N - 1)
                    sb.Append(", ");
            }
            sb.Append("]");
            return sb.ToString();
        }

    }
}
