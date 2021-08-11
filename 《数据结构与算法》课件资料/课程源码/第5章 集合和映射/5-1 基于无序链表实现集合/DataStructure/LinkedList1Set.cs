using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinkedList1Set<E>:ISet<E>
    {
        private LinkedList1<E> list;

        public LinkedList1Set()
        {
            list = new LinkedList1<E>();
        }

        //O（1）
        public int Count { get { return list.Count; } }

        //O（1）
        public bool IsEmpty { get { return list.IsEmpty; } }

        //O（n）
        public void Add(E e)
        {
            if (!list.Contains(e))
                list.AddFirst(e);
        }

        //O（n)
        public bool Contains(E e)
        {
           return list.Contains(e);
        }

        //O（n)
        public void Remove(E e)
        {
            list.Remove(e);
        }
    }
}
