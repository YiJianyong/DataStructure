using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class HashST1Set<Key>:ISet<Key>
    {
        private HashST1<Key> hashST1;

        public int Count { get {return  hashST1.Count; } }

        public bool IsEmpty { get { return hashST1.IsEmpty; } }

        public HashST1Set(int M)
        {
            hashST1 = new HashST1<Key>(M);
        }

        public HashST1Set()
        {
            hashST1 = new HashST1<Key>();
        }

        public void Add(Key key)
        {
            hashST1.Add(key);
        }

        public void Remove(Key key)
        {
            hashST1.Remove(key);
        }

        public bool Contains(Key key)
        {
            return hashST1.Contains(key);
        }
    }
}
