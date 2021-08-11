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

        //返回左旋转后新的二叉查找树的根，对新的二叉查找树进行后续的修复操作
        //左旋转过程中保证二叉树的性质，左子树都比根节点小，右子树都比根节点大
        private Node LeftRotate(Node node)
        {
            Node x = node.right;
            node.right = x.left;
            x.left = node;
            x.color = node.color;
            node.color = Red;
            return x;
        }

        //颜色翻转
        private void FlipColors(Node node)
        {
            node.color = Red;
            node.left.color = Black;
            node.right.color = Black;
        }

        //     node                   x
        //    /   \     右旋转       /  \
        //   x    T2   ------->   T3   node
        //  / \                       /  \
        // T3  T1                     T1  T2

        //返回右旋转后新的二叉查找树的根，对新的二叉查找树进行后续的修复操作
        //右旋转过程中保证二叉树的性质，左子树都比根节点小，右子树都比根节点大
        private Node RightRoatate(Node node)
        {
            Node x = node.left;
            node.left = x.right;
            x.right = node;
            x.color = node.color;
            node.color = Red;
            return x;
        }
    }
}
