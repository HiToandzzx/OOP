using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaiTapTuan5
{
    class Point
    {
        int x; //gia tri truc tung
        int y; //gia tri truc hoanh

        public Point()
        {
            Console.Write("Nhap toa do x: ");
                x = int.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y: ");
                y = int.Parse(Console.ReadLine());
        }

        public Point(int x1, int y1)
        {
            x = x1;
            y = y1;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
        }

        public void Set(int x1, int y1)
        {
            x = x1;
            y = y1;
        }

        public void Print()
        {
            Console.WriteLine($"({x},{y})");
        }

        public int X
        {
            get{
                return x;
            }
            set{
                x = value;
            }
        }

        public int Y
        {
            get{
                return y;
            }
            set{
                y = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            //KHONG THAM SO
            Point p1 = new Point(); 
            Console.Write("Toa do p1: ");
            p1.Print();

            Console.Write("\nNhap toa do x: ");
                x = int.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y: ");
                y = int.Parse(Console.ReadLine());

            //CO THAM SO
            Point p2 = new Point(x, y);
            Console.Write("Toa do p2: ");
            p2.Print();

            //SAO CHEP
            Point p3 = new Point(p2); 
            Console.Write("\nToa do p3 = toa do p2: ");
            p3.Print();

            //THAY DOI GIA TRI P1
            p1.Set(1, 2); 

            //IN RA TOA DO P1
            Console.Write("\nToa do p1 sau khi thay doi x=1 va y=2: ");
            p1.Print(); 

            //IN RA TOA DO P2
            Console.Write("\nToa do p2: ");
            p2.Print(); 

            //GAN LAI GT CHO Y CUA P3
            p3.Y = 6; 

            Console.Write("\nToa do p3 sau khi gan y=6: ");
            //IN RA TOA DO P3
            p3.Print(); 

            Console.ReadKey();
        }
    }
}
