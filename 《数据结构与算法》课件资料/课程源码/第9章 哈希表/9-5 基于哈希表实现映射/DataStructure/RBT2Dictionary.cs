using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class RBT2Dictionary<Key,Value>:IDictionary<Key,Value> where Key:IComparable<Key>
    {
        private RBT2<Key, Value> rbt;

        public RBT2Dictionary()
        {
            rbt = new RBT2<Key, Value>();
        }

        public int Count { get { return rbt.Count; } }

        public bool IsEmpty { get { return rbt.IsEmpty; } }

        public void Add(Key key, Value value)
        {
            rbt.Add(key, value);
        }

        public bool ContainsKey(Key key)
        {
            return rbt.Contains(key);
        }

        public Value Get(Key key)
        {
            return rbt.Get(key);
        }

        public void Remove(Key key)
        {
            Console.WriteLine("待实现");
        }

        public void Set(Key key, Value newValue)
        {
            rbt.Set(key, newValue);
        }
    }
}
