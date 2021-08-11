using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    //链表栈
    class LinkedList1Stack<E>:IStack<E>
    {
        //链表作为底层数据结构存储元素
        private LinkedList1<E> list;

        //构造函数初始化链表
        public LinkedList1Stack()
        {
            list = new LinkedList1<E>();
        }

        //获取栈中元素个数 O（1）
        public int Count { get { return list.Count; } }

        //判断栈是否为空 O（1）
        public bool IsEmpty { get { return list.IsEmpty; } }

        //往栈顶添加元素 O（1）
        public void Push(E e)
        {
            list.AddFirst(e);
        }

        //删除栈顶元素 O（1）
        public E Pop()
        {
            return list.RemoveFirst();
        }

        //查看栈顶元素 O（1）
        public E Peek()
        {
            return list.GetFirst();
        }

        //打印链表栈信息
        public override string ToString()
        {
            return "Stack: top " + list.ToString();
        }
    }
}
