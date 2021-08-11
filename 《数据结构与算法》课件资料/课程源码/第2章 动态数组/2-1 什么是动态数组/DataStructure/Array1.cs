using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Array1
    {
        private int[] data;
        private int N;

        public Array1(int capacity)//构造函数
        {
            data = new int[capacity];
            N = 0;
        }

        public Array1() : this(10) { }//默认容量10

        public int Capacity  //数组的容量属性
        {
            get { return data.Length; }
        }

        public int Count  //数组的实际存储元素个数 
        {
            get { return N; }
        }

        public bool IsEmpty  //判断数组是否为空，返回布尔值
        {
            get { return N == 0; }
        }
    }
}
