using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    //第二版本的链表类，具备头尾指针
    class LinkedList2<E>
    {
        private class Node
        {
            public E e;
            public Node next;

            public Node(E e, Node next)
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
        private Node tail;  //尾指针标记链表尾部结点
        private int N;

        public LinkedList2()
        {
            head = null;
            tail = null;
            N = 0;
        }

        public int Count { get { return N; } }

        public bool IsEmpty { get { return N == 0; } }

        public void AddLast(E e)
        {
            Node node = new Node(e);

            if (IsEmpty)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
            N++;
        }

        public E RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException("链表为空");

            E e = head.e;
            head = head.next;

            N--;

            if (head == null)
                tail = null;

            return e;
        }

        public E GetFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException("链表为空");

            return head.e;
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
