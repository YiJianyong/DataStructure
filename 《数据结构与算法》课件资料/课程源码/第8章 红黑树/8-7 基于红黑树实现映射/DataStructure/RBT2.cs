using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class RBT2<Key,Value> where Key : IComparable<Key>
    {
        private const bool Red = true;
        private const bool Black = false;

        private class Node
        {
            public Key key;
            public Value value;
            public Node left;
            public Node right;
            public bool color;

            public Node(Key key,Value value)
            {
                this.key = key;
                this.value = value;
                left = null;
                right = null;
                color = Red;
            }
        }

        private Node root;
        private int N;

        public RBT2()
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
        public void Add(Key key,Value value)
        {
            root = Add(root, key,value);
            root.color = Black;
        }

        //以node为根的树中添加元素e，添加后返回根节点node
        private Node Add(Node node, Key key,Value value)
        {
            if (node == null)
            {
                N++;
                return new Node(key,value); //默认为红结点
            }

            if (key.CompareTo(node.key) < 0)
                node.left = Add(node.left, key, value);
            else if (key.CompareTo(node.key) > 0)
                node.right = Add(node.right, key, value);
            else //key.CompareTo(node.key) == 0
                node.value = value;


            //如果出现右子结点是红色，而左子结点是黑色，进行左旋转
            if (IsRed(node.right) && !IsRed(node.left))
                node = LeftRotate(node);

            //如果出现连续的左子结点都为红色，进行右旋转
            if (IsRed(node.left) && IsRed(node.left.left))
                node = RightRoatate(node);

            //如果出现左右子结点均为红色，进行颜色翻转
            if (IsRed(node.left) && IsRed(node.right))
                FlipColors(node);


            return node;
        }

        private Node GetNode(Node node, Key key)
        {
            if (node == null) return null;

            if (key.Equals(node.key))
                return node;
            else if (key.CompareTo(node.key) < 0)
                return GetNode(node.left, key);
            else //key.CompareTo(node.key) > 0
                return GetNode(node.right, key);
        }

        public bool Contains(Key key)
        {
            return GetNode(root, key) != null;
        }

        public Value Get(Key key)
        {
            Node node = GetNode(root, key);

            if (node == null)
                throw new ArgumentException("键" + key + "不存在，无法获取对应值");
            else
                return node.value;
        }

        public void Set(Key key, Value newValue)
        {
            Node node = GetNode(root, key);

            if (node == null)
                throw new ArgumentException("键" + key + "不存在，无法更改对应值");
            else
                node.value = newValue;
        }
    }
}
