using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class HashST1<Key>
    {
        private LinkedList1<Key>[] hashtable;
        private int N;
        private int M;

        public HashST1(int M)
        {
            this.M = M;
            N = 0;
            hashtable = new LinkedList1<Key>[M];
            for (int i = 0; i < M; i++)
                hashtable[i] = new LinkedList1<Key>();
        }

        public HashST1() : this(97) { }

        public int Count { get { return N; } }

        public bool IsEmpty { get { return N == 0; } }

        private int Hash(Key key)
        {
            return (key.GetHashCode() & 0x7fffffff) % M;
        }

        public void Add(Key key)
        {
            LinkedList1<Key> list=hashtable[Hash(key)];
            if (list.Contains(key)) return;
            else
            {
                list.AddFirst(key);
                N++;
            }
        }

        public void Remove(Key key)
        {
            LinkedList1<Key> list = hashtable[Hash(key)];
            if (list.Contains(key))
            {
                list.Remove(key);
                N--;
            }
        }

        public bool Contains(Key key)
        {
            LinkedList1<Key> list = hashtable[Hash(key)];
            return list.Contains(key);
        }
    }
}
