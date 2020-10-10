using System;
using System.Text;
using System.IO;
namespace bths1
{
    class DIEM
    {
        private double x, y;
        public DIEM()
        {
            x = y = 0;
        }
        public DIEM(double x, double y)
        {
            this.x = x; this.y = y;
        }
        public void nhap()
        {
            Console.Write("nhập x: "); x = double.Parse(Console.ReadLine());
            Console.Write("nhập y: "); y = double.Parse(Console.ReadLine());
        }
        public void hien()
        {
            Console.WriteLine("tọa độ là: {0},{1} ", x, y);
        }
        public double khoangcach(DIEM b)
        {
            return Math.Sqrt(Math.Pow(b.x - this.x, 2) + Math.Pow(b.y - this.y, 2));
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            DIEM a = new DIEM(); a.nhap(); a.hien();
            DIEM b = new DIEM(); b.nhap(); b.hien();
            Console.WriteLine("khoảng cách là: " + a.khoangcach(b));
            Console.ReadKey();

        }
    }
}
