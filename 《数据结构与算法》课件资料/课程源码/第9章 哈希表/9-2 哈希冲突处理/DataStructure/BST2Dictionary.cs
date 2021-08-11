using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class BST2Dictionary<Key,Value>:IDictionary<Key,Value> where Key:IComparable<Key>
    {
        private BST2<Key, Value> bst;

        public BST2Dictionary()
        {
            bst = new BST2<Key, Value>();
        }

        public int Count { get { return bst.Count; } }

        public bool IsEmpty { get { return bst.IsEmpty; } }

        public void Add(Key key, Value value)
        {
            bst.Add(key, value);
        }

        public bool ContainsKey(Key key)
        {
           return bst.Contains(key);
        }

        public Value Get(Key key)
        {
           return bst.Get(key);
        }

        public void Remove(Key key)
        {
            bst.Remove(key);
        }

        public void Set(Key key, Value newValue)
        {
            bst.Set(key, newValue);
        }
    }
}
