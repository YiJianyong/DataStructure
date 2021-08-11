using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class RBT1<E> where E : IComparable<E>
    {
        private const bool Red = true;
        private const bool Black = false;

        private class Node
        {
            public E e;
            public Node left;
            public Node right;
            public bool color;

            public Node(E e)
            {
                this.e = e;
                left = null;
                right = null;
                color = Red;
            }
        }

        private Node root;
        private int N;

        public RBT1()
        {
            root = null;
            N = 0;
        }

        public int Count { get { return N; } }

        public bool IsEmpty { get { return N == 0; } }

        //判断节点是否为红色
        private bool IsRed(Node node)
        {
            if (node == null)
                return Black;

            return node.color;
        }

        //   node                     x
        //  /   \     左旋转         /  \
        // T1   x   --------->   node   T3
        //     / \              /   \
        //    T2 T3            T1   T2

        //返回左旋转后新的二叉查找树的根
        private Node LeftRotate(Node node)
        {
            Node x = node.right;
            node.right = x.left;
            x.left = node;
            x.color = node.color;
            node.color = Red;
            return x;
        }
    }
}
