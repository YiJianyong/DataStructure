using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    //数组队列
    class Array1Queue<E>:IQueue<E>
    {
        //动态数组作为底层的数据结构
        private Array1<E> arr;

        //创建容量为capacity的队列
        public Array1Queue(int capacity)
        {
            arr = new Array1<E>(capacity);
        }

        //使用默认的容量创建队列
        public Array1Queue()
        {
            arr = new Array1<E>();
        }

        //获取队列元素的个数 O（1）
        public int Count { get { return arr.Count; } }

        //查看队列是否为空 O（1）
        public bool IsEmpty { get { return arr.IsEmpty; } }

        //入队。往队尾添加元素 O（1）
        public void Enqueue(E e)
        {
            arr.AddLast(e);
        }

        //出队。删除队首的元素 O（n）
        public E Dequeue()
        {
            return arr.RemoveFirst();
        }

        //查看队首的元素 O（1）
        public E Peek()
        {
            return arr.GetFirst();
        }

        //打印数组队列信息
        public override string ToString()
        {
            return "Queue: front " + arr.ToString() + " tail";
        }
    }
}
