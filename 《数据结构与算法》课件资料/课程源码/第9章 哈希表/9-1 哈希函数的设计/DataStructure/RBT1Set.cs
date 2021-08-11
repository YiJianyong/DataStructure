using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class RBT1Set<E>:ISet<E> where E:IComparable<E>
    {
        private RBT1<E> rbt;

        public RBT1Set()
        {
            rbt = new RBT1<E>();
        }

        public int Count { get { return rbt.Count; } }

        public bool IsEmpty { get { return rbt.IsEmpty; } }

        public void Add(E e)
        {
            rbt.Add(e);
        }

        public bool Contains(E e)
        {
            return rbt.Contains(e);
        }

        public void Remove(E e)
        {
            Console.WriteLine("待实现");
        }

        public int MaxHeight()
        {
            return rbt.MaxHeight();
        }
    }
}
