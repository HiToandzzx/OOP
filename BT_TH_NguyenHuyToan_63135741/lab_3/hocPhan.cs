using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class hocPhan
    {
        string mssv, name;
        byte soTC, soTCTH;
        static int HP = 250;

        public byte SoTCTH { get => soTCTH; set => soTCTH = value; }

        public hocPhan() 
        {
            mssv = "63135741";
            name = "Nguyen Huy Toan";
            soTC = 12;
            soTCTH = 6;
        }

        public hocPhan(string mssv, string name, byte soTC, byte soTCTH)
        {
            this.mssv = mssv;
            this.name = name;
            this.soTC = soTC;
            this.soTCTH = soTCTH;
        }   

        public void Nhap()
        {
            Console.Write("\nNhap ma so sinh vien: ");
            mssv = Console.ReadLine();
            Console.Write("Nhap ho ten sinh vien: ");
            name = Console.ReadLine();
            Console.Write("Nhap so tin chi: ");
            soTC = byte.Parse(Console.ReadLine());
            Console.Write("Nhap so tin chi thuc hanh: ");
            soTCTH = byte.Parse(Console.ReadLine());
        }

        public float tinhHP()
        {
            return soTCTH * HP * 1.5f + (soTC - soTCTH) * HP;
        }

        public void Xuat()
        {
            Console.Write($"MSSV: {mssv}");
            Console.Write($"Ho va ten sinh vien: {name}");
            Console.Write($"So tin chi: {soTC}");
            Console.Write($"So tin chi thuc hanh: {soTCTH}");
            Console.Write($"Tien hoc phi: {tinhHP()}");
        }

        public static float operator +(float s, hocPhan hp)
        {
            return s + hp.tinhHP();
        }
    }

    internal class hoaDonHP
    {
        string mssv, name;
        hocPhan[] ds;
        byte n;

        public hoaDonHP()
        {
            mssv = "63135741";
            name = "Nguyen Huy Toan";
        }

        public hoaDonHP(string mssv, string name)
        {
            this.mssv = mssv;
            this.name = name;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap so hoa don: ");
            n = byte.Parse(Console.ReadLine());
            ds = new hocPhan[n];
            for (int i = 0; i < n; i++)
            {
                ds[i] = new hocPhan();
                ds[i].Nhap();
            }
        }

        public void Xuat()
        {
            float tongTien = 0;
            Console.WriteLine($"{mssv}\n{name}");
            foreach (hocPhan hp in ds)
            {
                hp.Xuat();
                tongTien += hp.tinhHP();
                Console.WriteLine();
            }
        }

        public int tongTC()
        {
            int tongtc = 0;
            foreach (hocPhan hp in ds)
                tongtc = tongtc + hp.SoTCTH;
            return tongtc;
        }
    }


}

