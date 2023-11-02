using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class hocVien
    {
        string maHV, tenHV, lop;
        byte soTiet;
        static float HP = 100f;

        public hocVien() 
        {
            maHV = "SO345";
            tenHV = "Nguyen Huy Toan";
            lop = "A";
            soTiet = 12;
        }

        public hocVien(string maHV, string tenHV, string lop, byte soTiet)
        {
            this.maHV = maHV;
            this.tenHV = tenHV;
            this.lop = lop;
            this.soTiet = soTiet;
        }

        public void Nhap()
        {
            Console.Write("\nNhap va hoc vien: ");
            maHV = Console.ReadLine();
            Console.Write("Nhap ten hoc vien: ");
            tenHV = Console.ReadLine();

            do
            {
                Console.Write("Nhap lop hoc (lop A, B, C): ");
            }while (lop != "A" && lop != "B" || lop != "C");

            Console.Write("Nhap so tiet: ");
            soTiet = byte.Parse(Console.ReadLine());
        }

        float tienGiam()
        {
            if (soTiet > 50)
                return soTiet * HP * 0.1f;
            else if (soTiet > 30 && soTiet <= 50)
                return soTiet * HP * 0.07f;
            else
                return soTiet * HP;
        }

        float tinhHP()
        {
            return soTiet * HP - tienGiam();
        }

        public void Xuat()
        {
            Console.WriteLine("===========================");
            Console.Write($"Ho ten: {tenHV}\nLop: {lop}\nSo tiet: {soTiet}\nTien hoc phi: {tinhHP()}");
        }
        public static float operator +(hocVien hv, float s)
        {
            return hv.tinhHP() + s;
        }
    }
}
