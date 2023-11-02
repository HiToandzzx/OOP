using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class phanSo
    {
        int ts, ms;
        //khoi tao
        public phanSo()
        {
            ts = 2; 
            ms = 3;
        }
        public phanSo(int t, int m)
        {
            ts = t; 
            ms = m;
        }
        //phuong thuc CONG
        public phanSo Cong(phanSo p)
        {
            phanSo kq = new phanSo();
            kq.ts = ts * p.ms + p.ts * ms;
            kq.ms = ms * p.ms;
            return kq;
        }

        //phuong thuc TRU
        public phanSo Tru(phanSo p)
        {
            phanSo kq = new phanSo();
            kq.ts = ts * p.ms - p.ts * ms;
            kq.ms = ms * p.ms;
            return kq;
        }

        //phuong thuc NHAN
        public phanSo Nhan(phanSo p)
        {
            phanSo kq = new phanSo();
            kq.ts = p.ts * ts;
            kq.ms = p.ms * ms;
            return kq;
        }

        //phuong thuc CHIA
        public phanSo Chia(phanSo p)
        {
            phanSo kq = new phanSo();
            kq.ts = p.ts * ms;
            kq.ms = p.ms * ts;
            return kq;
        }

        //Toan tu CONG
        public static phanSo operator +(phanSo p1, phanSo p2)
        {
            phanSo kq = new phanSo();
            kq.ts = p1.ts * p2.ms + p2.ts * p1.ms;
            kq.ms = p1.ms * p2.ms;
            return kq;
        }

        //Toan tu TRU
        public static phanSo operator -(phanSo p1, phanSo p2)
        {
            phanSo kq = new phanSo();
            kq.ts = p1.ts * p2.ms - p2.ts * p1.ms;
            kq.ms = p1.ms * p2.ms;
            return kq;
        }

        //Toan tu NHAN
        public static phanSo operator *(phanSo p1, phanSo p2)
        {
            phanSo kq = new phanSo();
            kq.ts = p1.ts * p2.ts;
            kq.ms = p1.ms * p2.ms;
            return kq;
        }

        //Toan tu CHIA
        public static phanSo operator /(phanSo p1, phanSo p2)
        {
            phanSo kq = new phanSo();
            kq.ts = p1.ts * p2.ms;
            kq.ms = p1.ms * p2.ts;
            return kq;
        }

        //rut gon phan so
        int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        public phanSo RutGon()//thao tac tren this
        {
            int t = UCLN(ts, ms);
            ts = ts / t;
            ms = ms / t;
            return this;
        }
        //xuat
        public void Xuat()
        {
            Console.Write($"{ts}/{ms}  ");
        }
    }
}
