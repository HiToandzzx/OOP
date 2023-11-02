using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Circle
    {
        float radius; //BAN KINH DUONG TRON

        //PHUONG THUC KHOI TAO KHONG THAM SO
        public Circle()
        {
            radius = 1;
        }

        //PHUONG THUC KHOI TAO CO THAM SO
        public Circle(float radius)
        {
            this.radius = radius;
        }

        //TRA VE GIA TRI BAN KINH
        public float GetRadius()
        {
            return radius;
        }

        //GAN GIA TRI R BANG 1 GIA TRI DUA VAO
        public void SetRadius(float R)
        {
            radius = R;
        }

        //TINH CHU VI
        public double GetPerimeter()
        {
            return 2 * radius * Math.PI;
        }

        //TINH DIEN TICH
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
    }
}
