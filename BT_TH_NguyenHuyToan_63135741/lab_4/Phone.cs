using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Phone
    {
        protected string id, name;
        protected float cost;
        protected int year;
        public int Year { get => year; set => year = value; }
        public float Cost { get => cost; set => cost = value; }

        // KHOI TAO
        public Phone()
        {
            id = "ip13"; 
            name = "Iphone 13 pro max 1TB";
            cost = 17.5f;
            year = 2023;
        }
        public Phone(string id, string name, float price, int year)
        {
            this.id = id;
            this.name = name;
            this.cost = price;
            this.year = year;
        }

        // NHAP
        public void Input()
        {
            Console.Write("\nNhap id phone: ");
            id = Console.ReadLine();
            Console.Write("Nhap nhan hieu: ");
            name = Console.ReadLine();
            Console.Write("Nhap gia: ");
            cost = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap nam san xuat: ");
            year = int.Parse(Console.ReadLine());
        }

        // XUAT
        public void Print()
        {
            Console.Write($"{id}\t{name}\t{cost}\t{year}");
        }

        // THUE NHAP
        public float Tax()
        {
            if (name == "Iphone")
                return cost * 10 / 100;
            else
                return 5 / 100 * cost;
        }
    }

    class SmartPhone : Phone
    {
        short dungLuong;

        // KHOI TAO
        public SmartPhone() : base()
        {
            dungLuong = 256;
        }

        public SmartPhone(string i, string n, float p, int y, short mem) : base(i, n, p, y)
        {
            this.dungLuong = mem;
        }
        //nhap dung co che dinh nghia lai phuong thuc
        public new void Input()
        {
            base.Input();
            Console.Write("Nhap dung luong bo nho: ");
            dungLuong = short.Parse(Console.ReadLine());
        }
        //xuat
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"\t{dungLuong}");
        }
        //tinh gia ban
        public float Price()
        {
            float p = 0;
            if (dungLuong >= 128)
                p = cost + 20 / 100 * cost + Tax();
            else if (dungLuong > 16)
                p = cost + 10 / 100 * cost + Tax();
            else
                p = cost + 5 / 100 * cost + Tax();
            return p;
        }
    }

    //danh sach n smartphone
    class List_SmartPhone
    {
        SmartPhone[] ls;
        int n;
        //su dung khoi tao khong tham so mac dinh
        //nhap
        public void Input()
        {
            Console.Write("Nhap so luong smartphone: ");
            while (!(int.TryParse(Console.ReadLine(), out n)) || n < 2 || n > 30)
            {
                Console.Write("\nNhap lai n:");
            }
            //khoi tao mang ls
            ls = new SmartPhone[n + 1];
            //nhap vao cac phan tu
            for (int i = 0; i < n; i++)
            {
                ls[i] = new SmartPhone();
                ls[i].Input();
            }
        }
        //them 1 smartphone
        public void Add()
        {
            Console.Write("\nNhap vao doi tuong can them: ");
            SmartPhone s = new SmartPhone();
            s.Input();
            Console.Write("\nNhap vao vi tri muon chen:");
            int p = int.Parse(Console.ReadLine());
            if (p >= 0 && p < n)
            {
                ls[n] = new SmartPhone();
                for (int i = n; i>p; i--)
                    ls[i] = ls[i - 1];
                ls[p] = s;
                n++;
            }
            else
                Console.WriteLine("\nVi tri khong hop le!");
        }
        // XOA
        public void Delete()
        {
            for (int i = 0; i < n; i++)
                if (ls[i].Year == DateTime.Now.Year)
                {
                    for (int j = i; j < n - 1; j++)
                        ls[j] = ls[j + 1];
                    n--;
                    break;
                }
        }

        // SAP XEP
        public void Sort()
        {
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (ls[i].Cost < ls[j].Cost)
                    {
                        SmartPhone s = new SmartPhone();
                        s = ls[i];
                        ls[i] = ls[j];
                        ls[j] = s;
                    }
        }

        //XUAT DANH SACH
        public void Print()
        {
            for (int i = 0; i < n; i++)
                ls[i].Print();
        }
    }
}

