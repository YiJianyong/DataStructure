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

        //往二叉查找树中添加元素，非递归实现
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

        //往二叉查找树中添加元素，递归实现
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

        //查询二叉查找树是否包含元素e
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
        // 二叉查找树的前序遍历
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

        // 二叉查找树的中序遍历
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

        // 二叉查找树的后序遍历
        public void PostOrder()
        {
            PostOrder(root);
        }

        // 后序遍历以node为根的二叉查找树
        private void PostOrder(Node node)
        {

            if (node == null)
                return;

            PostOrder(node.left);
            PostOrder(node.right);
            Console.WriteLine(node.e);
        }

        // 二叉查找树的层序遍历
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

        // 寻找二叉查找树的最小元素
        public E Min()
        {
            if (IsEmpty)
                throw new ArgumentException("空树！");

            return Min(root).e;
        }

        // 返回以node为根的二叉查找树的最小值所在的节点
        private Node Min(Node node)
        {
            if (node.left == null)
                return node;

            return Min(node.left);
        }

        // 寻找二叉查找树的最大元素
        public E Max()
        {
            if (IsEmpty)
                throw new ArgumentException("空树！");

            return Max(root).e;
        }

        // 返回以node为根的二叉查找树的最大值所在的节点
        private Node Max(Node node)
        {
            if (node.right == null)
                return node;

           return Max(node.right);
        }

        // 从二叉查找树中删除最小值所在节点
        public E RemoveMin()
        {
            E ret = Min();
            root=RemoveMin(root);
            return ret;
        }

        // 删除掉以node为根的二叉查找树中的最小节点
        // 返回删除节点后新的二叉查找树的根
        private Node RemoveMin(Node node)
        {
            if (node.left == null)
            {
                N--;
                return node.right;
            }

            node.left=RemoveMin(node.left);
            return node;
        }

        // 从二叉查找树中删除最大值所在节点
        public E RemoveMax()
        {
            E ret = Max();
            root = RemoveMax(root);
            return ret;
        }

        // 删除掉以node为根的二叉查找树中的最大节点
        // 返回删除节点后新的二叉查找树的根
        private Node RemoveMax(Node node)
        {

            if (node.right == null)
            {
                N--;
                return node.left;
            }

            node.right = RemoveMax(node.right);
            return node;
        }

        // 从二叉查找树中删除元素为e的节点
        public void Remove(E e)
        {
            root=Remove(root, e);
        }

        // 删除掉以node为根的二叉查找树中值为e的节点
        // 返回删除节点后新的二叉查找树的根
        private Node Remove(Node node, E e)
        {
            if (node == null) return null;

            if (e.CompareTo(node.e) < 0)
            {
                node.left=Remove(node.left, e);
                return node;
            }
            else if (e.CompareTo(node.e) > 0)
            {
                node.right=Remove(node.right, e);
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
                // 找到比待删除节点大的最小节点, 即待删除节点右子树的最小节点
                // 用这个节点顶替待删除节点的位置

                Node s=Min(node.right);
                s.right=RemoveMin(node.right);
                s.left = node.left;

                return s;
            }
        }
    }
}
