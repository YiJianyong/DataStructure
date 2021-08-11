using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    //数组栈
    class Array1Stack<E>:IStack<E>
    {
        //动态数组作为底层的数据结构
        private Array1<E> arr;

        //初始化容量为capacity的数组栈
        public Array1Stack(int capacity)
        {
            arr = new Array1<E>(capacity);
        }

        //使用默认容量的数组栈 
        public Array1Stack()
        {
            arr = new Array1<E>();
        }

        //获取栈中元素个数 O（1）
        public int Count { get { return arr.Count; } }

        //判断栈是否为空 O（1）
        public bool IsEmpty { get { return arr.IsEmpty; } }

        //往栈顶添加元素 O（1）
        public void Push(E e)
        {
            arr.AddLast(e);
        }

        //删除栈顶元素 O（1）
        public E Pop()
        {
            return arr.RemoveLast();
        }

        //查看栈顶元素 O（1）
        public E Peek()
        {
            return arr.GetLast();
        }

        //打印数组栈信息
        public override string ToString()
        {
            return "Stack: " + arr.ToString() + "top";
        }
    }
}
