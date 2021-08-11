using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
       
        //计算n的阶乘
        public static int Func(int n)
        {
            if (n == 1) return 1;           //递归终止条件（直到最小的子问题，得到解）
            else return n * Func(n - 1);    //递推公式（将原问题转化为更小的子问题进行求解）
        }

        //设计递归函数思路
        //1.明确函数的功能语义：
        //Func（n）对应的功能为：求解n的阶乘。之后求n-1的阶乘就可以调用此函数了。
        //2.寻找原问题与子问题的关系：
        //我们以Func（n）表示n的阶乘，显然当 n > 1 时都满足 Func（n）=n*Func（n-1）
        //3.寻找递归终止条件：
        //当n==1时 不满足递推公式，递归终止，得到最小子问题的解 即 Func（1）= 1

        //例如，求解Func（3）
        //Func（3）= 3 *Func（2）
        //Func（2）= 2 *Func（1）
        //Func（1）= 1

        //递归：由上往下为递、由下往上是归

        //递：将原问题拆成最小的子问题进行求解
        //我想要求解到（原问题）3的阶乘，那么我就必须先求解到（更小子问题）2的阶乘
        //我想要求解到（更小子问题）2的阶乘，那么我就必须先求解到（最小子问题）1的阶乘。

        //归：通过最小子问题的解往回得到原问题的解
        //当求解到了（最小子问题）1的阶乘的结果，再返回上一层函数的调用
        //进而求解到（更小子问题）2的阶乘的结果，再返回上一层函数的调用
        //从而得到（原问题）3的阶乘的结果

        //对于递归程序的微观解读，我在ppt中添加了新的补充
        //大家可以对着ppt，一步一步的分析程序的执行顺序，相信会有更好的理解 :)

        static void Main(string[] args)
        {

            Console.WriteLine(Func(1));
            Console.WriteLine(Func(4));



            Console.Read();
        }
    }
}
