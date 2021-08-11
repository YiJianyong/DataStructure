using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class HashST1<Key>
    {
        private LinkedList1<Key>[] hashtable;  //每个位置都指向一条链表，将冲突的元素都存在链表中。
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

        //将键转化为数组的索引
        private int Hash(Key key)
        {
            return (key.GetHashCode() & 0x7fffffff) % M;
        }
    }
}
