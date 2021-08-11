using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    //第三版的链表类，只具备头指针，存储键值对的数据
    class LinkedList3<Key,Value>
    {
        //私有的内部结点类
        //这个类相比较以前的LinkedList1的结点类多存储了一个value变量而已
        private class Node
        {
            public Key key;         //键
            public Value value;     //值
            public Node next;

            public Node (Key key,Value value,Node next)
            {
                this.key = key;
                this.value = value;
                this.next = next;
            }

            public override string ToString()
            {
                return key.ToString() + " : " + value.ToString();
            }
        }

        private Node head;
        private int N;

        public LinkedList3()
        {
            head = null;
            N = 0;
        }

        public int Count { get { return N; } }

        public bool IsEmpty { get { return N == 0; } }

        //私有的辅助函数，通过键查找对应的结点
        //有了它作为前提，能更方便的实现增删改查相应的功能
        private Node GetNode(Key key)
        {
            Node cur = head;
            while (cur != null)
            {
                if (cur.key.Equals(key))
                    return cur;

                cur = cur.next;
            }
            return null;
        }

        //往链表添加键值对数据
        public void Add(Key key,Value value)
        {
            Node node = GetNode(key);

            //如果结点不存在，则创建新节点
            if (node == null)
            {
                head = new Node(key, value, head);
                N++;
            }
            else //存在的话，就更新一下键对应的值
                node.value = value;
        }

        //查看链表中是否包含指定键
        public bool Contains(Key key)
        {
            return GetNode(key) != null;
        }

        //通过键获取对应的值
        public Value Get(Key key)
        {
            Node node = GetNode(key);

            if (node == null)
                throw new ArgumentException("键" + key + "不存在");
            else
                return node.value;
        }

        //将键对应的值改成一个新的值
        public void Set(Key key,Value newValue)
        {
            Node node = GetNode(key);

            if (node == null)
                throw new ArgumentException("键" + key + "不存在");
            else
                node.value = newValue;
        }

        //通过键删除结点中存储的储键值对数据
        public void Remove(Key key)
        {
            if (head == null)
                return;

            if (head.key.Equals(key))
            {
                head = head.next;
                N--;
            }
            else
            {
                Node cur = head;
                Node pre = null;

                while (cur != null)
                {
                    if (cur.key.Equals(key))
                        break;

                    pre = cur;
                    cur = cur.next;
                }

                if (cur != null)
                {
                    pre.next = pre.next.next;
                    N--;
                }
            }
        }
    }
}
