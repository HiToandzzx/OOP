using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class PhepToan
    {
        int x, y;
        char phepToan;

        public void Nhap(int, int, char)
        {
            Console.Write("Nhap so dau tien: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Phep toan: ");
            phepToan = Convert.ToChar(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            y = Convert.ToInt32(Console.ReadLine());
        }

        public float tinhToan(int, int, char)
        {
            if (phepToan == '+')
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            else if (phepToan == '-')
                Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            else if ((phepToan == 'x') || (phepToan == '*'))
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            else if (phepToan == '/')
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            else
                Console.WriteLine("Ban da nhap sai phep toan!!!");
            Console.ReadKey();
        } 
    }
}
