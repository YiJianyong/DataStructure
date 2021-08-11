using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    //Student是一个可比较的类型
    //实现了IComparable<Student>接口中的比较方法CompareTo（）
    class Student :IComparable<Student>
    {
        private string name;
        private int tall;

        public Student(string name,int tall)
        {
            this.name = name;
            this.tall = tall;
        }

        //自定义比较大小的方法。
        //通过身高进行比较。
        public int CompareTo(Student other)
        {
            if (this.tall > other.tall) return 1;
            if (this.tall < other.tall) return -1;
            return 0;
        }

        public override string ToString()
        {
            return "{" + name + ":" + tall + "}";
        }
    }
}
