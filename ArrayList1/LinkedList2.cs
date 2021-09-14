using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1
{
    class LinkedList2<T>
    {
        //第二版：具有头、尾指针
        private class Node  //Node类 
        {
            public T e;
            public Node next;

            //Node的构造函数
            public Node(T e, Node next)
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

        private Node head;//头指针
        private Node tail;//尾指针
        private int N;

        //链表的构造函数
        public LinkedList2()
        {
            head = null;
            tail = null;
            N = 0;
        }
       
        //属性Count、IsEmpty
        public int Count { get { return N; } }

        public bool IsEmpty { get { return N == 0; } }

        public void AddLast(T e)
        {
            Node newNode = new Node(e);

            if (IsEmpty)//链表为空
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            N--;
        }

        public T RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException("链表为空");

            T del = head.e;
            head = head.next;

            N--;
            if (head == null)
                tail = null;

            return del;
        }



        public T GetFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException("链表为空");

            return head.e;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("head:");
            Node cur = head;
            while(cur != null)
            {
                str.Append(cur + "->");
                cur = cur.next;
            }
            str.Append("null");
            return str.ToString();
        }
    }
}
