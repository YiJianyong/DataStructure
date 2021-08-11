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

        //非递归添加
        public void add(E e)
        {
            //根结点没有父亲结点需要单独的判断
            if (root == null)
            {
                root = new Node(e);     //新创建的结点为根结点
                N++;
                return;
            }

            Node pre = null;    //pre是cur的父亲结点
            Node cur = root;    //cur是pre的孩子结点

            //循环里面移动cur指针
            while (cur != null)
            {
                //树中不允许添加重复元素
                if (e.CompareTo(cur.e) == 0)
                    return;

                //记录cur的位置
                pre = cur;

                //移动cur指向
                if (e.CompareTo(cur.e) < 0)     
                    cur = cur.left;     //向左移动 在左子树中查找
                else   //e.CompareTo(cur.e) > 0 
                    cur = cur.right;    //向右移动 在右子树中查找
            }

            //while循环结束cur==null，通过元素e创建新结点放到cur中
            cur = new Node(e);

            //判断cur是pre的左孩子还是右孩子
            if (e.CompareTo(pre.e) < 0)
                pre.left = cur;     //cur是pre的左孩子
            else  //e.CompareTo(pre.e) > 0
                pre.right = cur;    //cur是pre的右孩子

            N++;
        }
    }
}
