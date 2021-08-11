using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinkedList3Dictionary<Key,Value>:IDictionary<Key,Value>
    {
        private LinkedList3<Key, Value> list;

        public LinkedList3Dictionary()
        {
            list = new LinkedList3<Key, Value>();
        }

        //O（1）
        public int Count { get { return list.Count; } }

        //O（1）
        public bool IsEmpty { get { return list.IsEmpty; } }

        //O（1）
        public void Add(Key key, Value value)
        {
            list.Add(key, value);
        }

        //O（n）
        public bool ContainsKey(Key key)
        {
            return list.Contains(key);
        }

        //O（n）
        public Value Get(Key key)
        {
            return list.Get(key);
        }

        //O（n）
        public void Remove(Key key)
        {
            list.Remove(key);
        }

        //O（n）
        public void Set(Key key, Value newValue)
        {
            list.Set(key, newValue);
        }
    }
}
