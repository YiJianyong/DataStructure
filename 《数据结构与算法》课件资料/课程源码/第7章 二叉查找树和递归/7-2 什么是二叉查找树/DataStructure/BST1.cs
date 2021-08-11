using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class BST1<E> where E:IComparable<E>
    {
        private class Node
        {
            public E e;
            public Node left;
            public Node right;

            public Node(E e)
            {
                this.e = e;
                left = null;
                right = null;
            }
        }

        private Node root;
        private int N;

        public BST1()
        {
            root = null;
            N = 0;
        }

        public int Count { get { return N; } }

        public bool IsEmpty { get { return N == 0; } }
    }
}
