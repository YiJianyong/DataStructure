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

        public int Count { get { return list.Count; } }

        public bool IsEmpty { get { return list.IsEmpty; } }

        public void Add(E e)
        {
            if (!list.Contains(e))
                list.AddFirst(e);
        }

        public bool Contains(E e)
        {
           return list.Contains(e);
        }

        public void Remove(E e)
        {
            list.Remove(e);
        }
    }
}
