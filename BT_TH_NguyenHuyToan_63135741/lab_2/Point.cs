using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    //LOP POINT
    internal class Point
    {
        short x; //Hoanh do
        short y; //Tung do

        //PHUONG THUC KHOI TAO KHONG THAM SO
        public Point()
        {
            x = 1;
            y = 3;
        }

        //PHUONG THUC KHOI TAO CO THAM SO
        public Point(short x, short y)
        {
            this.x = x;
            this.y = y;
        }

        //IN RA MAN HINH
        public void Output()
        {
            Console.WriteLine($"({x}, {y}) ");
        }

        //TINH KHOANG CACH
        public float Distance(Point p)
        {
            float kq = (float) Math.Sqrt((p.x - x)*(p.x - x) + (p.y - y)*(p.y - y)); 
            return kq;
        }
    }
}
