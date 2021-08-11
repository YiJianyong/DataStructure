using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinkedList1Queue<E>:IQueue<E>
    {
        private LinkedList1<E> list;

        public LinkedList1Queue()
        {
            list = new LinkedList1<E>();
        }

        //O（1）
        public int Count { get { return list.Count; } }

        //O（1）
        public bool IsEmpty { get { return list.IsEmpty; } }

        //O（1）
        public E Dequeue()
        {
            return list.RemoveFirst();
        }

        //O（n）
        public void Enqueue(E e)
        {
            list.AddLast(e);
        }

        //O（1）
        public E Peek()
        {
            return list.GetFirst();
        }

        public override string ToString()
        {
            return "Queue front " + list.ToString() + " tail";
        }
    }
}
