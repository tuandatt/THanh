using System;
using System.Text;

namespace TH2_bai2
{
    class PS
    {
        private int tu, mau;
        public PS()
        {
            tu = 0;
            mau = 0;
        }
        public PS(int x, int y)
        {
            this.tu = tu;
            this.mau = mau;
        }
        public void nhap()
        {
            Console.Write("Nhập tử số: "); 
            tu = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: "); 
            mau = int.Parse(Console.ReadLine());
        }
        public void hien()
        {
            Console.Write("Phân số là: ");
            Console.WriteLine($"{tu}/{mau}");
        }
        public int Uscln(int x, int y)
        {
            x = Math.Abs(x); y = Math.Abs(y);
            while (x != y)
            {
                if (x > y) x = x - y;
                if (y > x) y = y - x;
            }
            return x;
        }
        public PS rutgon()
        {
            int uc = Uscln(this.tu, this.mau);
            this.tu = this.tu / uc;
            this.mau = this.mau / uc;
            return this;
        }
        public static PS operator +(PS t1, PS t2)
        {
            PS t = new PS();
            t.tu = t1.tu * t2.mau + t1.mau * t2.tu;
            t.mau = t1.mau * t2.mau;
            return t;
        }
        public static PS operator -(PS t1, PS t2)
        {
            PS t = new PS();
            t.tu = t1.tu * t2.mau - t1.mau * t2.tu;
            t.mau = t1.mau * t2.mau;
            return t;
        }
        public static PS operator /(PS t1, PS t2)
        {
            PS t = new PS();
            t.tu = t1.tu * t2.mau;
            t.mau = t1.mau * t2.tu;
            return t;
        }
        public static PS operator *(PS t1, PS t2)
        {
            PS t = new PS();
            t.tu = t1.tu * t2.tu;
            t.mau = t1.mau * t2.mau;
            return t;
        }
        public static bool operator >(PS t1, PS t2)
        {
            return t1.tu * t2.mau > t2.tu * t1.mau;
        }
        public static bool operator <(PS t1, PS t2)
        {
            return t1.tu * t2.mau < t2.tu * t1.mau;
        }
    }
    class test
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            PS t = new PS();
            t.nhap(); t.hien();
            PS t2 = new PS();
            t2.nhap(); t2.hien();
            PS t3 = t + t2; t3.hien();
            PS t4 = t * t2; t4.hien();
            if (t > t2)
            {
                Console.WriteLine("Phân số t1 > t2");
            }
            else if (t < t2)
            {
                Console.WriteLine("Phân số t1 < t2");
            }
            else
                Console.WriteLine("Hai phân số = nhau");
            Console.ReadKey();
        }
    }
}
