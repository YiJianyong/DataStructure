using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1
{
    interface IQueue<T>
    {
        int Count { get; }

        bool IsEmpty { get; }

        //入队
        void Enqueue(T e);

        //出队
        T Dequeue();

        //查看队首元素
        T Peek();
    }
}
