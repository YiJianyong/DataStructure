using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1
{
    class Array2Stack<T>:IStack<T>
    {
        //基于Array2数组实现的数组栈
        private Array2<T> arr;  //Array2作为底层数据结构

        //初始化数组栈的大小
        public Array2Stack(int capacity)
        {
            arr = new Array2<T>(capacity);
        }

        //使用默认容量的数组栈 
        public Array2Stack()
        {
            arr = new Array2<T>();
        }



        public int Count { get { return arr.Count; } }

        public bool IsEmpty { get { return arr.IsEmpty; } }

        //出栈
        public T Pop()
        {
            return arr.RemoveLast();
        }

        //入栈
        public void Push(T e)
        {
            arr.AddLast(e);
        }

        //查看栈顶的元素
        public T Peek()
        {
            return arr.GetLast();
        }

        //top标记一下栈顶
        public override string ToString()
        {
            return "Stack:" + arr.ToString() + "top";
        }
    }
}
