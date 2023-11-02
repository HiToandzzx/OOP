using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Shape
    {
        string name;

        // KHOI TAO
        public Shape(string name = "")
        {
            this.name = name;
        }

        // TINH CHU VI
        public virtual float Pre()
        {
            return 0;
        }

        // TINH DIEN TICH
        public virtual float Area()
        {
            return 0;
        }

        //IN THOGN TIN HINH
        public void Print()
        {
            Console.WriteLine($"{name}\tChu vi: {Pre()}\t Dien tich: {Area()}");
        }
    }

    // DAN XUAT

    // LOP TAM GIAC
    class Triangle : Shape
    {
        float a, b, c;

        // KHOI TAO
        public Triangle(float a = 2, float b = 3, float c = 4, string n = "Triangle") : base(n)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        // TINH CHU VI
        public override float Pre()
        {
            return a + b + c;
        }

        //TINH DIEN TICH
        public override float Area()
        {
            float p = Pre() / 2;
            return (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }

    //LOP HINH CHU NHAT
    class Rectangle : Shape
    {
        float d, r;

        // KHOI TAO
        public Rectangle(float d = 5, float r = 4, string n = "Rectangle") : base(n)
        {
            this.d = d;
            this.r = r;
        }

        // TINH CHU VI
        public override float Pre()
        {
            return (d + r) * 2;
        }

        // TINH DIEN TICH
        public override float Area()
        {
            return d * r;
        }
    }

    // DANH SACH N HINH
    class List_Shape
    {
        int n;
        Shape[] ls;
        // KHOI TAO MAC DINH
        // NHAP
        public void Input()
        {
            Console.Write("\nNhap n hinh (2 <= n <= 20): ");
            while (!(int.TryParse(Console.ReadLine(), out n)) || n < 2 || n > 20)
            {
                Console.Write("\nNhap lai n:");
            }

            // KHOI TAO MANG
            ls = new Shape[n];

            //NHAP N PHAN TU
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n1.Triangle\n2.Rectangle\n Your choice is?: ");
                byte choice = byte.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    float a, b, c;
                    do
                    {
                        Console.Write("\nNhap do dai 3 canh tam giac: ");
                        a = float.Parse(Console.ReadLine());
                        b = float.Parse(Console.ReadLine());
                        c = float.Parse(Console.ReadLine());
                    } while (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a);
                    ls[i] = new Triangle(a, b, c);
                }
                else
                {
                    float d, r;
                    do
                    {
                        Console.Write("\nNhap chieu dai, chieu rong HCN:");
                        d = float.Parse(Console.ReadLine());
                        r = float.Parse(Console.ReadLine());
                    } while (d < r);
                    ls[i] = new Rectangle(d, r);
                }
            }
        }

        // XUAT
        public void Print()
        {
            foreach (Shape s in ls)
                s.Print();
        }

        // TINH DIEN TICH TB CUA CAC HCN
        public float Avg_Area()
        {
            float s = 0; // TONG DIEN TICH
            int c = 0; // SO LUONG HCN
            for (int i = 0; i < ls.Length; i++)
                if (ls[i].GetType() == typeof(Rectangle))
                {
                    s = s + ls[i].Area();
                    c++;
                }
            return s / c;
        }
    }
}

