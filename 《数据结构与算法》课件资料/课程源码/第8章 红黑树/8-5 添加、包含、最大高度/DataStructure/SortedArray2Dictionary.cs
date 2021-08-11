using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class SortedArray2Dictionary<Key,Value>:IDictionary<Key,Value> where Key:IComparable<Key>
    {
        private SortedArray2<Key, Value> s2;

        public int Count { get { return s2.Count; } }

        public bool IsEmpty { get { return s2.IsEmpty; } }

        public SortedArray2Dictionary(int capacity)
        {
            s2 = new SortedArray2<Key, Value>(capacity);
        }

        public SortedArray2Dictionary()
        {
            s2 = new SortedArray2<Key, Value>();
        }

        //O(n)
        public void Add(Key key, Value value)
        {
            s2.Add(key, value);
        }

        //O(n)
        public void Remove(Key key)
        {
            s2.Remove(key);
        }

        //O(log n)
        public bool ContainsKey(Key key)
        {
            return s2.Contains(key);
        }

        //O(log n)
        public Value Get(Key key)
        {
           return  s2.Get(key);
        }

        //O(log n)
        public void Set(Key key, Value newValue)
        {
            s2.Add(key, newValue);
        }
    }
}
