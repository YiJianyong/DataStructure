using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    //辅助测试类
    class TestHelper
    {
        //私有的构造函数，不允许外部进行实例化
        //换句话说就是不能通过new关键字创建一个TestHelper类对象
        private TestHelper() { }

        //读取名为filename的文件并将它进行简单分词后存入动态数组List中
        public static List<string> ReadFile(string filename)
        {
            //使用FileStream类打开filename文件
            FileStream fs = new FileStream(filename, FileMode.Open);

            //使用StreamReader读取filename文件信息
            StreamReader sr = new StreamReader(fs);

            //将读取的单词存入动态数组words中
            List<string> words = new List<string>();


            while (!sr.EndOfStream)
            {
                string contents = sr.ReadLine().Trim();
                int start = FirstCharacterIndex(contents, 0);

                for (int i = start + 1; i <= contents.Length;)
                {
                    if (i == contents.Length || !Char.IsLetter(contents[i]))
                    {
                        string word = contents.Substring(start, i - start).ToLower();
                        words.Add(word);
                        start = FirstCharacterIndex(contents, i);
                        i = start + 1;
                    }
                    else
                        i++;
                }
            }

            fs.Close();
            sr.Close();

            return words;
        }

        // 寻找字符串s中，从start的位置开始的第一个字母字符的位置
        private static int FirstCharacterIndex(string s, int start)
        {
            for (int i = start; i < s.Length; i++)
                if (Char.IsLetter(s[i]))
                    return i;

            return s.Length;
        }
    }
}
