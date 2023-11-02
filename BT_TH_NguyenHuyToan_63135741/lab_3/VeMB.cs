using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class VeMB
    {
        string mave, hoten, loaive;
        DateTime ngaymua, ngaykh;
        static int giasan = 500;

        public string Loaive { get => loaive; set => loaive = value; }

        //khoi tao
        public VeMB()
        {
            mave = "SOT357";
            hoten = "Nguyễn Huy Toàn";
            ngaymua = DateTime.Today;
            ngaykh = new DateTime(2023, 5, 1);
            loaive = "Medium";
        }
        public VeMB(string ma,string ht,DateTime mua,DateTime kh,string loai)
        {
            mave = ma;
            hoten = ht;
            loaive = loai;
            ngaymua = mua;
            ngaykh = kh;
        }
        //nhap thong tin ve
        public void Nhap()
        {
            Console.Write("Nhap ma ve: ");
            mave = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap ngay mua: ");
            ngaymua  =DateTime.Parse( Console.ReadLine());
            Console.Write("Nhap ngay khoi hanh: ");
            ngaykh = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap loai ve: ");
            loaive = Console.ReadLine();
        }

        //Tinh tien ve
        public float TinhGiaVe()
        {
            float gia;//gia theo loaive
            if (loaive == "First")
                gia = giasan * 3;
            else if (loaive == "Business")
                gia = giasan * 2;
            else if (loaive == "Premium")
                gia = giasan * 1.5f;
            else
                gia = giasan;

            //tinh so ngay
            int d = (ngaykh - ngaymua).Days;
            return (0.5f / 100 * d * gia)*1.1f;
        }

        //Xuat thong tin ve
        public void Xuat()
        {
            Console.WriteLine("\n======================");
            Console.Write($"\nMa ve: {mave}");
            Console.Write($"\nHo va ten: {hoten}");
            Console.Write($"\nNgay khoi hanh: {ngaykh.ToShortDateString()}");
            Console.Write($"\nLoai ve: {loaive}");
            Console.Write($"\nGia ve: {TinhGiaVe()}");
        }

        //toan tu +
        public static float operator + (float s,VeMB ve)
        {
            return s + ve.TinhGiaVe();
        }

        //toan tu <,>
        public static bool operator < (VeMB v1,VeMB v2)
        {
            return v1.TinhGiaVe() < v2.TinhGiaVe();             
        }
        public static bool operator > (VeMB v1, VeMB v2)
        {
            return v1.TinhGiaVe() > v2.TinhGiaVe();
        }
    }

    //class danh sach n ve may bay
    class DS_VeMB
    {
        VeMB[] ds;
        byte n;
        //phuong thuc nhap
        public void Nhap()
        {
            do
            {
                Console.Write("Nhap so luong ve:");
                n = byte.Parse(Console.ReadLine());
            } while (n < 2 || n > 20);
            //khoi tao ds
            ds = new VeMB[n];
            //nhap n ve may bay
            for (int i = 0; i < n; i++)
            {
                ds[i] = new VeMB();
                ds[i].Nhap();
            }
        }

        //sap xep 
        public void SapXep()
        {
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (ds[i] < ds[j])//(ds[i].TinhGiaVe() < ds[j].TinhGiaVe())
                    {
                        VeMB ve = new VeMB();
                        ve = ds[i];
                        ds[i] = ds[j];
                        ds[j] = ve;
                    }
        }
        //xuat n ve ra man hinh
        public void XuatDS()
        {
            foreach (VeMB ve in ds)
                ve.Xuat();
        }
        //tinh trung binh
        public void TinhTB()
        {
            //tinh tong tien n ve
            float s = 0;
            foreach (VeMB ve in ds)
                s = s + ve;//s + ve.TinhGiaVe();
            Console.WriteLine("Tien ve TB: {0}", s / n);
        }
        //dem so luong ve loai Business
        public void DemLoaiVe()
        {
            byte c = 0;
            foreach (VeMB ve in ds)
                if (ve.Loaive == "Business")
                    c++;
            Console.WriteLine("\nSo ve loai Business: {0}", c);
        }
    }
}
