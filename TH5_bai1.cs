using System;
using System.Text;

namespace TH5_bai1
{
    class TienDien
    {
        private string tench;
        private string dichi;
        private int SCTTTruoc, SCTTNay;
        public TienDien()
        {
            tench = dichi = " ";
            SCTTTruoc = SCTTNay = 0;
        }
        public TienDien(string tench, string DiaChi, int socongtothangtr, int socongtothangn)
        {
            this.tench = tench;
            this.dichi = DiaChi;
            this.SCTTTruoc = socongtothangtr;
            this.SCTTNay = socongtothangn;
        }
        public void nhap()
        {
            Console.Write("Nhập tên chủ hộ: ");
            tench = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            dichi = Console.ReadLine();
            Console.Write("Nhập số công tơ tháng trước: ");
            SCTTTruoc = int.Parse(Console.ReadLine());
            Console.Write("Nhập số công tơ tháng này: ");
            SCTTNay = int.Parse(Console.ReadLine());
        }
        public void hien()
        {
            Console.WriteLine("Tên chủ hộ \t\t Địa chỉ \t\t Số công tơ tiêu dùng");
            Console.WriteLine("{0}\t\t\t{1}\t\t\t\t{2}", tench, dichi, SCTTNay - SCTTTruoc);
            Console.WriteLine("Số tiền điện cần thanh toán: " + tinhtien());
        }
        public int socongtodasd
        {
            get
            {
                return SCTTNay - SCTTTruoc;
            }
        }
        public int tinhtien()
        {
            return socongtodasd * 500;
        }
    }
    class TienDienMoi : TienDien
    {
        private int dinhmuc;
        public TienDienMoi()
        {
            dinhmuc = 0;
        }
        public TienDienMoi(string tench, string diachi, int SCTTTruoc, int SCTTNay, int dinhmuc)
        {
            this.dinhmuc = dinhmuc;
        }
        public new void nhap()
        {
            base.nhap();
            Console.Write("Nhập định mức: ");
            dinhmuc = int.Parse(Console.ReadLine());
        }
        public new void hien()
        {
            base.hien();
        }
        public int TienDien()
        {
            if (socongtodasd < dinhmuc)
                return socongtodasd * 500;
            else
                return socongtodasd * 600;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            TienDienMoi t = new TienDienMoi();
            t.nhap();
            t.hien();
            t.tinhtien();
            Console.ReadKey();
        }
    }
}
