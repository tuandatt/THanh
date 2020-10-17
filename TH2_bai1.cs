﻿using System;
using System.Text;

namespace TH2_bai1
{
    class Stack
    {
        private int top;
        private int[] a;
        public bool empty()
        {
            return (top == -1);
        }
        public bool full()
        {
            return (top >= a.Length);
        }
        public Stack()
        {
            a = new int[20];
            top = -1;
        }
        public void push(int x)
        {
            if (!full())
            {
                top = top + 1;
                a[top] = x;
            }
            else
                Console.Write("stack tran");
        }
        public int pop()
        {
            if (empty())
            {
                Console.Write("stack can");
                return 0;
            }
            else
                return a[top--];
        }
    }
    class hecoso
    {
        static void Main1()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.Write("Nhập số cần đổi:");
            n = int.Parse(Console.ReadLine());
            Stack T = new Stack();
            string st = "0123456789ABCDEF";
            while (n != 0)
            {
                T.push((int)st[n % 16]);
                n = n / 16;
            }
            Console.Write("Kết quả sau khi đổi sang hệ 16 :");
            while (!T.empty())
            {
                Console.Write("{0}", (char)T.pop());
            }
            Console.ReadLine();
        }
    }
}
