using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1
{
    class LinkedList1Queue<T>:IQueue<T>
    {
        private LinkedList1<T> list;

        //构造函数

        public LinkedList1Queue()
        {
            list = new LinkedList1<T>();
        }

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
    }
}
