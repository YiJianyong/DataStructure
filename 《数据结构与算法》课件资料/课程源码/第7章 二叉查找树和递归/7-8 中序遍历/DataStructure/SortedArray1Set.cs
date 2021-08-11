using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class SortedArray1Set<Key>:ISet<Key> where Key:IComparable<Key>
    {
        private SortedArray1<Key> s;

        public int Count { get { return s.Count; } }

        public bool IsEmpty { get { return s.IsEmpty; } }

        public SortedArray1Set(int capacity)
        {
            s = new SortedArray1<Key>();
        }

        public SortedArray1Set()
        {
            s = new SortedArray1<Key>();
        }

        //O（n）
        public void Add(Key key)
        {
            s.Add(key);
        }

        //O（n）
        public void Remove(Key key)
        {
            s.Remove(key);
        }

        //O(log n)
        public bool Contains(Key key)
        {
            return  s.Contains(key);
        }
    }
}
