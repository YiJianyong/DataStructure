using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1
{
    class LinkedList2Queue<T>:IQueue<T>
    {
        //以第二版链表为底层数据结构实现的队列
        //使队列的入队和出队操作的时间复杂度都变成O(1)
        private LinkedList2<T> list;

        //构造函数
        public LinkedList2Queue()
        {
            list = new LinkedList2<T>(); 
        }

        //常用属性
        public int Count { get { return list.Count; } }

        public bool IsEmpty { get { return list.IsEmpty; } }


        public T Dequeue()
        {
            return list.RemoveFirst();
        }
        public void Enqueue(T e)
        {
            list.AddLast(e);
        }

        public T Peek()
        {
            return list.GetFirst();
        }

        public override string ToString()
        {
            return "Queue  front" + list.ToString() + "tail";
        }
    }
}
