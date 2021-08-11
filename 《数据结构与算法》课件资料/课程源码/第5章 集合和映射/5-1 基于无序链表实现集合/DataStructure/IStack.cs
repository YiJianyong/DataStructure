using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    interface IStack<E>
    {
        int Count { get; }

        bool IsEmpty { get; }

        void Push(E e);

        E Pop();

        E Peek();
    }
}
