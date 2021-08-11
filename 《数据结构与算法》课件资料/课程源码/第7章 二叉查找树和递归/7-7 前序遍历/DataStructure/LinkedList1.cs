using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    //第一版单链表
    class LinkedList1<E>
    {
        //私有的内部结点类
        private class Node
        {
            public E e;         //结点中存储的元素
            public Node next;   //存储下一个结点的引用

            //通过元素和下一个结点的引用创建结点
            public Node(E e,Node next)
            {
                this.e = e;
                this.next = next;
            }

            //通过元素创建结点
            public Node(E e)
            {
                this.e = e;
                this.next = null;
            }

            //输出结点的信息
            public override string ToString()
            {
                return e.ToString();
            }
        }

        //头指针标识链表的头部
        private Node head;  

        //链表中元素的个数
        private int N;      

        //链表初始化一个结点也没有，head指向空，N为0
        public LinkedList1()
        {
            head = null;
            N = 0;
        }

        //获取链表中元素的个数
        public int Count
        {
            get { return N; }
        }

        //判断链表是否为空
        public bool IsEmpty
        {
            get { return N == 0; }
        }

        //往链表添加元素
        public void Add(int index,E e)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("非法索引");

            if (index == 0)
            {
                //Node node = new Node(e);
                //node.next = head;
                //head = node;

                head=new Node(e, head);
            }
            else
            {
                Node pre = head;
                for (int i = 0; i < index-1; i++)
                    pre = pre.next;

                //Node node = new Node(e);
                //node.next = pre.next;
                //pre.next = node;

                pre.next = new Node(e, pre.next);
            }

            N++;
        }

        //在链表的头部添加元素
        public void AddFirst(E e)
        {
            Add(0, e);
        }

        //在链表的尾部添加元素
        public void AddLast(E e)
        {
            Add(N, e);
        }

        //获取链表第index位置的元素（从0开始计算）
        public E Get(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("非法索引");

            Node cur = head;
            for (int i = 0; i < index; i++)
                cur = cur.next;

            return cur.e; 
        }

        //获取链表头部元素
        public E GetFirst()
        {
            return Get(0);
        }

        //获取链表尾部元素
        public E GetLast()
        {
            return Get(N - 1);
        }

        //修改链表元素的值
        public void Set(int index,E newE)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("非法索引");

            Node cur = head;
            for (int i = 0; i < index; i++)
                cur = cur.next;

            cur.e = newE;
        }

        //查询链表中是否包含元素e
        public bool Contains(E e)
        {
            Node cur = head;
            while (cur != null)
            {
                if (cur.e.Equals(e))
                    return true;

                cur = cur.next;
            }

            return false;
        }

        //删除链表第index位置的元素（从0开始计算）
        public E RemoveAt(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("非法索引");

            if (index == 0)
            {
                Node delNode = head;
                head = head.next;
                N--;
                return delNode.e;
            }
            else
            {
                Node pre = head;
                for (int i = 0; i < index-1; i++)
                    pre = pre.next;

                Node delNode = pre.next;
                pre.next = delNode.next;
                N--;
                return delNode.e;
            }
        }
       
        //删除链表的头部元素
        public E RemoveFirst()
        {
            return RemoveAt(0);
        }

        //删除链表的尾部元素
        public E RemoveLast()
        {
            return RemoveAt(N - 1);
        }

        //删除链表指点的元素e
        public void Remove(E e)
        {
            if (head == null)
                return;

            if (head.e.Equals(e))
            {
                head = head.next;
                N--;
            }
            else
            {
                Node cur = head;
                Node pre = null;

                while (cur != null)
                {
                    if (cur.e.Equals(e))
                        break;

                    pre = cur;
                    cur = cur.next;
                }

                if (cur != null)
                {
                    pre.next = pre.next.next;
                    N--;
                }
            }
        }
      
        //打印链表
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            Node cur = head;
            while (cur != null)
            {
                res.Append(cur + "->");
                cur = cur.next;
            }
            res.Append("Null");
            return res.ToString();
        }
    }
}
