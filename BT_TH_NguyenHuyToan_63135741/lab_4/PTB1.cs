using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class PTB1
    {
        //bx + c =0
        protected float b, c;

        // KHOI TAO
        public PTB1()
        {
            b = 0; c = 0;
        }
        public PTB1(float b, float c)
        {
            this.b = b;
            this.c = c;
        }
        // NHAP
        public void Nhap()
        {
            Console.WriteLine("Nhap he so b, c (bx + c =0): ");
            b = Convert.ToSingle(Console.ReadLine());
            c = Convert.ToSingle(Console.ReadLine());
        }
        // XUAT
        public void Xuat()
        {
            Console.WriteLine($"{b}x + {c} = 0");
        }
        // GIAI
        public void Giai()
        {
            if (b == 0)
                if (c == 0)
                    Console.WriteLine("\nPT tren co vo so nghiem!");
                else
                    Console.WriteLine("\nPT tren vo nghiem!");
            else
            {
                float x = -c / b;
                Console.WriteLine($"\nPT tren co nghiem x = {x}");
            }
        }
    }

    class PTB2 : PTB1
    {
        //ax^2+bx+c=0
        float a;

        //KHOI TAO
        public PTB2() : base()
        {
            a = 0;
        }
        public PTB2(float a, float b, float c) : base(b, c)
        {
            this.a = a;
        }

        // NHAP DUNG CO CHE DINH NGHIA LAI
        public new void Nhap()
        {
            Console.Write("Nhap he so a (ax^2 + bx + c =0):");
            a = Convert.ToSingle(Console.ReadLine());
            base.Nhap();
        }

        // XUAT
        public new void Xuat()
        {
            Console.Write($"\n{a}x^2 + ");
            base.Xuat();
        }
        // GIAI
        public new void Giai()
        {
            if (a == 0)//bx+c=0
                base.Giai();
            else//ax^2+bx+c=0
            {
                float del = b * b - 4 * a * c;
                if (del < 0)
                    Console.WriteLine("\nPT tre vo nghiem!");
                else if (del == 0)
                {
                    float x = -b / (2 * a);
                    Console.WriteLine($"\nPT tren co nghiem kep x1 = x2 = {x}");
                }
                else
                {
                    float x1 = (float)(-b - Math.Sqrt(del)) / (2 * a);
                    float x2 = (float)(-b + Math.Sqrt(del)) / (2 * a);
                    Console.WriteLine($"\nPT tren co 2 nghiem phan biet x1 = {x1}, x2 = {x2}");
                }
            }
        }
    }
}
