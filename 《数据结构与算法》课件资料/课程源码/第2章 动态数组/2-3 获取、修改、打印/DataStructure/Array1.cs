using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Array1
    {
        private int[] data;
        private int N;

        public Array1(int capacity)
        {
            data = new int[capacity];
            N = 0;
        }

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
        
        public void Add(int index,int e)
        {
            if(index<0 || index > N)
                throw new ArgumentException("数组索引越界");

            if (N == data.Length)
                throw new ArgumentException("数组已满");

            for (int i = N-1; i >= index; i--)
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

        public int Get(int index)
        {
            if(index<0 || index>=N)
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

        public void Set(int index,int newE)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("数组索引越界");

            data[index] = newE;
        }

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
