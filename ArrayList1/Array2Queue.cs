using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1
{
    class Array2Queue<T>:IQueue<T>
    {
        //Array2数组作为底层数据结构
        private Array2<T> arr;

        //构造函数初始化数组
        public Array2Queue(int capacity)
        {
           arr = new Array2<T>(capacity);
        }

        public Array2Queue()
        {
            arr = new Array2<T>();
        }

        public int Count { get { return arr.Count; } }

        public bool IsEmpty { get { return arr.IsEmpty; } }

        public T Dequeue()
        {
            return arr.RemoveFirst();
        }

        public void Enqueue(T e)
        {
            arr.AddLast(e);
        }

        public T Peek()
        {
            return arr.GetFirst();
        }
    }
}
