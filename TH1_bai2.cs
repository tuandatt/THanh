using System;

namespace bai2
{
    class Employe
    {
        private int id, year;
        private string name;
        private double salary, basic;
        public double setsalary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public double setbasic
        {
            get
            {
                return basic;
            }
            set
            {
                basic = value;
            }
        }
        public int getid()
        {
            return id;
        }
        public string getname()
        {
            return name;
        }
        public int getyear()
        {
            return year;
        }
        public double getincome()
        {
            return salary * basic;
        }
        public void display()
        {
            Console.WriteLine("dinh danh\t ten\tnam sinh \tluong co ban\t thu nhap");
            Console.WriteLine(id + "\t" + name + "\t" + year + "\t\t" + basic + "\t" + getincome());
        }
        static void Main(string[] args)
        {
            Employe e = new Employe();
            e.display();
            Console.ReadKey();
        }
    }
}
