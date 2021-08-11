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

        //往红黑树中添加元素，递归实现
        public void Add(E e)
        {
            root = Add(root, e);
            root.color = Black;
        }

        //以node为根的树中添加元素e，添加后返回根节点node
        private Node Add(Node node, E e)
        {
            if (node == null)
            {
                N++;
                return new Node(e); //默认为红结点
            }

            if (e.CompareTo(node.e) < 0)
                node.left = Add(node.left, e);
            else if (e.CompareTo(node.e) > 0)
                node.right = Add(node.right, e);

            //如果出现右子结点是红色，而左子结点是黑色，进行左旋转
            if (IsRed(node.right) && !IsRed(node.left))
                node=LeftRotate(node);

            //如果出现连续的左子结点都为红色，进行右旋转
            if (IsRed(node.left) && IsRed(node.left.left))
                node=RightRoatate(node);

            //如果出现左右子结点均为红色，进行颜色翻转
            if (IsRed(node.left) && IsRed(node.right))
                FlipColors(node);


            return node;
        }

        //查询红黑树是否包含元素e
        public bool Contains(E e)
        {
            return Contains(root, e);
        }

        //以node为根的树是否包含元素e
        private bool Contains(Node node, E e)
        {
            if (node == null)
                return false;

            if (e.CompareTo(node.e) == 0)
                return true;
            else if (e.CompareTo(node.e) < 0)
                return Contains(node.left, e);
            else  //e.CompareTo(node.e) > 0
                return Contains(node.right, e);
        }

        //红黑树的最大高度
        public int MaxHeight()
        {
            return MaxHeight(root);
        }

        //计算以node为根的红黑树的最大高度
        private int MaxHeight(Node node)
        {
            if (node == null) return 0;

            //int l = MaxHeight(node.left);
            //int r = MaxHeight(node.right);
            //return Math.Max(l, r) + 1;

            //选择左右子树中最高的那一颗子树在加上node本身的高度。得到以node为根二叉树的最大高度
            return Math.Max(MaxHeight(node.left), MaxHeight(node.right)) + 1;
        }
    }
}
