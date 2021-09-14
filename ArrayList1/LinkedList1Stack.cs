using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1
{
    class LinkedList1Stack<T> : IStack<T>
    {
        //链表作为底层数据结构
        private LinkedList1<T> list;

        //构造函数：初始化链表
        public LinkedList1Stack()
        {
            list = new LinkedList1<T>();
        }
        public int Count { get { return list.Count; } }

        public bool IsEmpty { get { return list.IsEmpty; } }

        //获取栈顶元素
        public T Peek()
        {
            return list.GetFirst();
        }

        public T Pop()
        {
            return list.RemoveFirst();
        }

        public void Push(T e)
        {
            list.AddFirst(e);
        }
    }
    
}
