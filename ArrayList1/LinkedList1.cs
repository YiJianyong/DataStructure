using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1
{
    class LinkedList1<T>
    {
        //第一版：仅具有头指针
        private class Node  //Node类 
        {
            public T e;
            public Node next;

            public Node(T e,Node next)
            {
                this.e = e;
                this.next = next;
            }

            public Node(T e)
            {
                this.e = e;
                this.next = null;
            }

            public override string ToString()
            {
                return e.ToString();
            }
        }

        private Node head;
        private int N;

        public LinkedList1()     //构造函数
        {
            head = null;
            N = 0;
        }
        
        public int Count  //Count属性 计数元素个数
        {
            get { return N; }
        }

        public bool IsEmpty
        {
            get { return N == 0; }
        }

        public void Add(int index,T e) //在指定索引处添加元素
        {
            if (index < 0 || index > N)  //index = N时是AddLast()方法的参数
                throw new ArgumentException("索引越界");
          

            if (index == 0)
            {
                //Node的构造函数表明下面三行代码与另一行代码等价
                //Node node = new Node(e);
                //node.next = head;
                //head = node;

                head = new Node(e, head);
            }
            else
            {
                Node pre = head;
                for(int i = 0;i < index - 1; i++)
                {
                    pre = pre.next;
                }
                //Node node = new Node(e);
                //node.next = pre.next;
                //pre.next = node;

                pre.next = new Node(e, pre.next);
            }
            N++;  //更新元素个数
          
        }

        public void AddFirst(T e)
        {
            Add(0, e);
        }

        public void AddLast(T e)
        {
            Add(N, e);
        }
       
        public T Get(int index)    //获取指定索引处的元素
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("索引越界");

            Node cur = head;
            for(int i = 0;i < index; i++)
            {
                cur = cur.next;
            }
            return cur.e;
        }

        public T GetFirst()
        {
            return Get(0);
        }

        public T GetLast()
        {
            return Get(N - 1);
        }
        public void Set(int index,T newE)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("索引越界");

            Node cur = head;
            for(int i = 0;i < index; i++)
            {
                cur = cur.next;
            }
            cur.e = newE;
        }
        public bool Contains(T e)
        {
            Node cur = head;
            while(cur != null)
            {
                if (cur.e.Equals(e))
                    return true;

                cur = cur.next;
            }
            return false;
        }

        public T RemoveAt(int index)
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
                for (int i = 0; i < index - 1; i++)
                    pre = pre.next;

                Node delNode = pre.next;
                pre.next = delNode.next;
                N--;
                return delNode.e;
            }
        }

        //删除链表的头部元素
        public T RemoveFirst()
        {
            return RemoveAt(0);
        }

        //删除链表的尾部元素
        public T RemoveLast()
        {
            return RemoveAt(N - 1);
        }

        //删除链表指点的元素e
        public void Remove(T e)
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

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            Node cur = head;
            while(cur != null)
            {
                res.Append(cur + "->");
                cur = cur.next;
            }
            res.Append("Null");
            return res.ToString();
        }

    }
}
