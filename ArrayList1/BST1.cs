using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1
{
    //where T:IComparable<T> 对T进行泛型约束，限定T类型，不能是任意类型
    class BST1<T> where T:IComparable<T>
    {
        //定义一个私有结点类
        private class Node
        {
            public T e;
            public Node left;
            public Node right;

            //Node类的构造函数
            public Node(T e)
            {
                this.e = e;   //值
                left = null;  //左孩子结点
                right = null; //右孩子结点
            }
        }

        private Node root;  //根结点
        private int N;      //统计结点个数

        //构造函数
        public BST1()
        {
            root = null;
            N = 0;
        }
        
        //一些常用属性
        public int Count { get { return N; } }

        public bool IsEmpty { get { return N == 0; } }


        public void Add(T e)
        {
            root = Add(root, e);
        }

        private Node Add(Node node,T e)
        {
            if (node == null)
            {
                N++;
                return new Node(e);
            }

            if (e.CompareTo(node.e) < 0)
                node.left = Add(node.left, e);
            else if (e.CompareTo(node.e) > 0)
                node.right = Add(node.right, e);

            return node;
        }

        public bool Contains(T e)
        {
            return Contains(root, e);
        }

        //以node为根结点的树中是否包含e这个结点
        private bool Contains(Node node,T e)
        {
            if (node == null)
                return false;
            if (e.CompareTo(node.e) == 0)
                return true;
            else if (e.CompareTo(node.e) < 0)
                return Contains(node.left.e);
            else  //e.CompareTo(node.e) > 0
                return Contains(node.right.e);
        }

        public void PreOrder()
        {
            PreOrder(root);
            Console.WriteLine("null");
        }

        // 前序遍历以node为根的二叉查找树(root -> left -> right)
        private void PreOrder(Node node)
        {
            if (node == null)
                return;
            //遍历的顺序取决与这三条语句的执行顺序
            Console.Write(node.e + "->");
            PreOrder(node.left);
            PreOrder(node.right);
        }

        public void InOrder()
        {
            InOrder(root);
            Console.WriteLine("null");
        }

        //中序遍历以node为根的二叉查找树(left -> root -> right)
        private void InOrder(Node node)
        {
            if (node == null)
                return;

            InOrder(node.left);
            Console.Write(node.e + "->");
            InOrder(node.right);
        }

        public void PostOrder()
        {
            PostOrder(root);
            Console.WriteLine("null");
        }
        // 后序遍历以node为根的二分搜索树, 递归算法(left -> right -> root)
        private void PostOrder(Node node)
        {
            if (node == null)
                return;

            PostOrder(node.left);
            PostOrder(node.right);
            Console.Write(node.e + "->");
        }

        //层序遍历： 以队列为底层数据结构实现(利用队列的先进先出的特性实现对树的层序遍历)
        public void LevelOrder()
        {
            //将结点对象插入
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while(q.Count != 0)
            {
                Node cur = q.Dequeue();
                Console.Write(cur.e + "->"); ;

                if (cur.left != null)
                    q.Enqueue(cur.left);
                if (cur.right != null)
                    q.Enqueue(cur.right);   
            }
            Console.WriteLine("null");
        }

    }
}
