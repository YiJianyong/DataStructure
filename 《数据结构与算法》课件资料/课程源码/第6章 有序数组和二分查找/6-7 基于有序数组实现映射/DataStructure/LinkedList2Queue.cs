using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinkedList2Queue<E> : IQueue<E>
    {
        private LinkedList2<E> list;

        public LinkedList2Queue()
        {
            list = new LinkedList2<E>();
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

        //O（1）
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
