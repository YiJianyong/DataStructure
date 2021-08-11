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

        public void add(E e)
        {
            if (root == null)
            {
                root = new Node(e); 
                N++;
                return;
            }

            Node pre = null;    
            Node cur = root;    

            while (cur != null)
            {
                if (e.CompareTo(cur.e) == 0)
                    return;

                pre = cur;

                if (e.CompareTo(cur.e) < 0)     
                    cur = cur.left;     
                else   //e.CompareTo(cur.e) > 0 
                    cur = cur.right;    
            }

            cur = new Node(e);

            if (e.CompareTo(pre.e) < 0)
                pre.left = cur;     
            else    //e.CompareTo(pre.e) > 0
                pre.right = cur;    

            N++;
        }

        public void Add(E e)
        {
            root=Add(root, e);
        }

        //以node为根的树中添加元素e，添加后返回根节点node
        private Node Add(Node node,E e)
        {
            if (node == null)
            {
                N++;
                return new Node(e);
            }

            if (e.CompareTo(node.e) < 0)
                node.left = Add(node.left, e);
            else if (e.CompareTo(node.e) > 0)
                node.right=Add(node.right, e);

            return node;
        }

        public bool Contains(E e)
        {
            return Contains(root, e);
        }

        //以node为根的树是否包含元素e
        private bool Contains(Node node,E e)
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

        public void PreOrder()
        {
            PreOrder(root);
        }

        // 前序遍历以node为根的二叉查找树
        private void PreOrder(Node node)
        {
            if (node == null)
                return;

            Console.WriteLine(node.e);
            PreOrder(node.left);
            PreOrder(node.right);
        }

        public void InOrder()
        {
            InOrder(root);
        }

        //中序遍历以node为根的二叉查找树
        private void InOrder(Node node)
        {
            if (node == null)
                return;

            InOrder(node.left);
            Console.WriteLine(node.e);
            InOrder(node.right);
        }

        // 二分搜索树的后序遍历
        public void PostOrder()
        {
            PostOrder(root);
        }

        // 后序遍历以node为根的二分搜索树, 递归算法
        private void PostOrder(Node node)
        {

            if (node == null)
                return;

            PostOrder(node.left);
            PostOrder(node.right);
            Console.WriteLine(node.e);
        }

        public void LevelOrder()
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                Node cur = q.Dequeue();
                Console.WriteLine(cur.e);

                if (cur.left != null)
                    q.Enqueue(cur.left);

                if (cur.right != null)
                    q.Enqueue(cur.right);
            }
        }
    }
}
