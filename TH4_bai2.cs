using System;
using System.Text;

namespace TH4_bai2
{
    class nhanvien
    {
        private string hoten, quequan;
        private double hesoluong;
        private int luongcoban;
        public nhanvien()
        {
            luongcoban = 1000;
        }
        public static int LuongCoBan
        {
            get { return LuongCoBan; }
            set
            {
                if (value > 1000)
                    LuongCoBan = value;
            }
        }
        public void Nhap()
        {
            Console.Write("Nhập họ tên:");
            hoten = Console.ReadLine();
            Console.Write("Nhập quê quán:");
            quequan = Console.ReadLine();
            Console.Write("Nhập hệ số lương:");
            hesoluong = double.Parse(Console.ReadLine());
        }
        public double tinhluong
        {
            get { return hesoluong * luongcoban; }
        }
        public void Hien()
        {
            Console.WriteLine("Họ và tên: " + hoten);
            Console.WriteLine("Quê quán: " + quequan);
            Console.WriteLine("Hệ số lươnh: " + hesoluong);
            Console.WriteLine("Tính lương: " + tinhluong);
        }
        public static double Max(double x, double y)
        {
            return x > y ? x : y;
        }
    }
    class QLyNhanvien
    {
        private nhanvien[] ds;
        private int sonv;
        public void Hien()
        {
            Console.WriteLine("   THÔNG TIN NHÂN VIÊN   ");
            foreach (nhanvien x in ds)
                x.Hien();
        }
        public void Nhap()
        {
            Console.Write("Nhập số lượng nhân viên: ");
            sonv = int.Parse(Console.ReadLine());
            ds = new nhanvien[sonv];
            Console.WriteLine("   NHẬP THÔNG TIN NHÂN VIÊN  ");
            for (int i = 0; i < ds.Length; i++)
            {
                ds[i] = new nhanvien();
                ds[i].Nhap();
            }
        }
        public void Hienluongmax()
        {
            double luongmax = ds[0].tinhluong;
            for (int i = 0; i < ds.Length; ++i)
                luongmax = nhanvien.Max(luongmax, ds[i].tinhluong);
            Console.WriteLine("Lương cán bộ cao nhất là: " + luongmax);
        }
    }
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            QLyNhanvien t = new QLyNhanvien();
            t.Nhap();
            t.Hien();
            t.Hienluongmax();
            Console.ReadKey();
        }
    }
}
