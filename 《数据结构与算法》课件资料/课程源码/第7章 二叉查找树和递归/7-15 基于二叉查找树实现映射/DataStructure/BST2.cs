using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class BST2<Key,Value> where Key : IComparable<Key>
    {
        private class Node
        {
            public Key key;
            public Value value;
            public Node left;
            public Node right;

            public Node(Key key,Value value)
            {
                this.key = key;
                this.value = value;
                left = null;
                right = null;
            }
        }

        private Node root;
        private int N;

        public BST2()
        {
            root = null;
            N = 0;
        }

        public int Count { get { return N; } }

        public bool IsEmpty { get { return N == 0; } }

        public void Add(Key key,Value value)
        {
            root = Add(root, key,value);
        }

        private Node Add(Node node, Key key,Value value)
        {
            if (node == null)
            {
                N++;
                return new Node(key,value);
            }

            if (key.CompareTo(node.key) < 0)
                node.left = Add(node.left, key, value);
            else if (key.CompareTo(node.key) > 0)
                node.right = Add(node.right, key, value);
            else
                node.value = value;

            return node;
        }

        private Node Min(Node node)
        {
            if (node.left == null)
                return node;
            return Min(node.left);
        }

        private Node RemoveMin(Node node)
        {

            if (node.left == null)
            {
                N--;
                return node.right;
            }

            node.left = RemoveMin(node.left);
            return node;
        }

        public void Remove(Key key)
        {
            root = Remove(root, key);
        }

        private Node Remove(Node node, Key key)
        {
            if (node == null) return null;

            if (key.CompareTo(node.key) < 0)
            {
                node.left = Remove(node.left, key);
                return node;
            }
            else if (key.CompareTo(node.key) > 0)
            {
                node.right = Remove(node.right, key);
                return node;
            }
            else //e.CompareTo(node.e) == 0
            {
                // 要删除的节点只有左孩子
                if (node.right == null)
                {
                    N--;
                    return node.left;
                }

                // 要删除的节点只有右孩子
                if (node.left == null)
                {
                    N--;
                    return node.right;
                }

                // 要删除的节点左右都有孩子
                Node s = Min(node.right);
                s.right = RemoveMin(node.right);
                s.left = node.left;

                return s;
            }
        }

        //返回以node为根节点的二叉查找树中，key所在的节点
        private Node GetNode(Node node,Key key)
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

        public void Set(Key key,Value newValue)
        {
            Node node = GetNode(root, key);

            if (node == null)
                throw new ArgumentException("键" + key + "不存在，无法更改对应值");
            else
                node.value = newValue;
        }
    }
}
