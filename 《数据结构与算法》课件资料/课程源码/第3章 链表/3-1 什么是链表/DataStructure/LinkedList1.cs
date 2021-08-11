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
    }
}
