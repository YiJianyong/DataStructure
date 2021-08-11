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
    }
}
