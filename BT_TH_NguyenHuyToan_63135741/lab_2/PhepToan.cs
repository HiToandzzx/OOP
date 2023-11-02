using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class PhepToan
    {
        float a, b;
        char c;

        public PhepToan(float a1 = 0, float b1 = 0, char c1 = '+')
        {
            a = a1; b = b1;
            c = c1;
        }

        public void CapNhat()
        {
            Console.Write("Nhập 2 số thực: ");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhập phép toán (+,-,*,/): ");
            c = char.Parse(Console.ReadLine());
        }

        float Tinhtoan()
        {
            float kq = 0;
            switch (c)
            {
                case '+': 
                    kq = a + b; 
                    break;
                case '-':
                    kq = a - b; 
                    break;
                case '*': 
                    kq = a * b; 
                    break;
                case '/': 
                    kq = a / b; 
                    break;
            }
            return kq;
        }

        public void Xuat()
        {
            Console.WriteLine($"{a}{c}{b}={Tinhtoan()}");
        }
        }
    }
