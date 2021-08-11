using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class HashST2Dictionary<Key,Value>:IDictionary<Key,Value>
    {
        private HashST2<Key, Value> hashST2;

        public int Count { get {return  hashST2.Count; } }

        public bool IsEmpty { get { return hashST2.IsEmpty; } }

        public HashST2Dictionary(int M)
        {
            hashST2 = new HashST2<Key, Value>(M);
        }

        public HashST2Dictionary()
        {
            hashST2 = new HashST2<Key, Value>();
        }

        public void Add(Key key, Value value)
        {
            hashST2.Add(key, value);
        }

        public void Remove(Key key)
        {
            hashST2.Remove(key);
        }

        public bool ContainsKey(Key key)
        {
           return hashST2.Contains(key);
        }

        public Value Get(Key key)
        {
            return hashST2.Get(key);
        }

        public void Set(Key key, Value newValue)
        {
            hashST2.Set(key, newValue);
        }
    }
}
