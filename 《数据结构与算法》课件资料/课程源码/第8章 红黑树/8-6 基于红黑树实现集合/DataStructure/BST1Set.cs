using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class BST1Set<E>:ISet<E> where E:IComparable<E>
    {
        private BST1<E> bst;

        public BST1Set()
        {
            bst = new BST1<E>();
        }

        public int Count { get { return bst.Count; } }

        public bool IsEmpty { get { return bst.IsEmpty; } }

        public void Add(E e)
        {
            bst.Add(e);
        }

        public bool Contains(E e)
        {
            return bst.Contains(e);
        }

        public void Remove(E e)
        {
            bst.Remove(e);
        }

        public int MaxHeight()
        {
            return bst.MaxHeight();
        }
    }
}
