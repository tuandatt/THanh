using System;
using System.Text;

namespace TH4_bai1
{
    class mtran
    {
        private int m, n;
        private int[,] a;
        public mtran()
        {
            m = n = 2;
            a = new int[m, n];
        }
        public mtran(int m, int n)
        {
            this.m = m;
            this.n = n;
            a = new int[m, n];

        }
        public mtran(mtran t2)
        {
            this.m = t2.m;
            this.n = t2.n;
            this.a = new int[m, n];
            for (int i = 0; i < m; ++i)
                for (int j = 0; j < n; ++j)
                    this.a[i, j] = t2.a[i, j];
        }
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập thông tin cho các phần tử của ma trận: ");
            for (int i = 0; i < m; ++i)
                for (int j = 0; j < n; ++j)
                {
                    Console.WriteLine("a{0},{1}=", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }
        public void Hien()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Các phần tử của ma trận: ");
            for (int i = 0; i < m; ++i)
                for (int j = 0; j < n; ++j)
                    Console.WriteLine("{0}\t", a[i, j]);
            Console.WriteLine();

        }
        public mtran Tong(mtran t2)
        {
            if (this.m == t2.m && this.n == t2.n)
            {
                mtran t = new mtran(this.m, this.n);
                for (int i = 0; i < t.m; ++i)
                    for (int j = 0; j < t.n; ++j)
                        t.a[i, j] = this.a[i, j] + t2.a[i, j];
                return t;
            }
            else return null;
        }
    }
    class test
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập thông tin cho ma trận: ");
            mtran t1 = new mtran(2, 3); t1.Nhap();
            Console.WriteLine("Nhập thông tin cho ma trận 1: ");
            mtran t2 = new mtran(t1);
            mtran t3 = t1.Tong(t2);
            if (t3 == null)
                Console.WriteLine("2 ma trận không cùng kích thước không tính được: ");
            else
            {
                Console.WriteLine("Thông tin ma trận tổng: ");
                t3.Hien();
            }
            Console.ReadKey();
        }
    }
}
