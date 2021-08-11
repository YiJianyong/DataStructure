using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinkedList1<E>
    {
        private class Node
        {
            public E e;         
            public Node next;   

            public Node(E e,Node next)
            {
                this.e = e;
                this.next = next;
            }

            public Node(E e)
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

        public LinkedList1()
        {
            head = null;
            N = 0;
        }

        public int Count
        {
            get { return N; }
        }

        public bool IsEmpty
        {
            get { return N == 0; }
        }

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

        public void AddFirst(E e)
        {
            Add(0, e);
        }

        public void AddLast(E e)
        {
            Add(N, e);
        }

        public E Get(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("非法索引");

            Node cur = head;
            for (int i = 0; i < index; i++)
                cur = cur.next;

            return cur.e;
        }

        public E GetFirst()
        {
            return Get(0);
        }

        public E GetLast()
        {
            return Get(N - 1);
        }

        public void Set(int index,E newE)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("非法索引");

            Node cur = head;
            for (int i = 0; i < index; i++)
                cur = cur.next;

            cur.e = newE;
        }

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
