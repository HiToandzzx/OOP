using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3;

namespace lab_3
{
    internal class Program
    {
        static void BT3_1()
        {
            phanSo p1 = new phanSo();
            Console.Write("Nhap tu so: ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            int m = int.Parse(Console.ReadLine());
            phanSo p2 = new phanSo(t, m);
            p1.Xuat(); 
            p2.Xuat();

            Console.Write("\nCong 2 phan so dung phuong thuc: ");
            phanSo p = new phanSo();
            p = p1.Cong(p2);
            p = p.RutGon();
            p.Xuat();
            Console.Write("\nCong 2 phan so dung toan tu: ");
            phanSo kq = new phanSo();
            kq = p1 + p2;
            kq = kq.RutGon();
            kq.Xuat();

            Console.Write("\n");
            Console.Write("\nTru 2 phan so dung phuong thuc: ");
            phanSo p3 = new phanSo();
            p3 = p1.Tru(p2);
            p3 = p3.RutGon();
            p3.Xuat();
            Console.Write("\nTru 2 phan so dung toan tu: ");
            phanSo kq2 = new phanSo();
            kq2 = p1 - p2;
            kq2 = kq2.RutGon();
            kq2.Xuat();

            Console.Write("\n");
            Console.Write("\nNhan 2 phan so dung phuong thuc: ");
            phanSo p4 = new phanSo();
            p4 = p1.Nhan(p2);
            p4 = p4.RutGon();
            p4.Xuat();
            Console.Write("\nNhan 2 phan so dung toan tu: ");
            phanSo kq3 = new phanSo();
            kq3 = p1 * p2;
            kq3 = kq3.RutGon();
            kq3.Xuat();

            Console.Write("\n");
            Console.Write("\nChia 2 phan so dung phuong thuc: ");
            phanSo p5 = new phanSo();
            p5 = p1.Chia(p2);
            p5 = p5.RutGon();
            p5.Xuat();
            Console.Write("\nChia 2 phan so dung toan tu: ");
            phanSo kq4 = new phanSo();
            kq4 = p1 / p2;
            kq4 = kq4.RutGon();
            kq4.Xuat();

        }

        static void BT3_2()
        {
            VeMB[] ds;
            byte n;
            do
            {
                Console.Write("Nhap so luong ve MB: ");
                n = byte.Parse(Console.ReadLine());
            } while (n < 2 || n > 20);

            //Khoi tao ds
            ds = new VeMB[n];

            //nhap n ve may bay
            for (int i = 0; i < n; i++)
            {
                ds[i] = new VeMB();
                ds[i].Nhap();
            }

            //sap xep 
            for (int i=0; i<n; i++)
                for (int j=i+1; j<n; j++)
                    if (ds[i] < ds[j])
                    {
                        VeMB ve = new VeMB();
                        ve = ds[i];
                        ds[i] = ds[j];
                        ds[j] = ve;
                    }

            //xuat n ve ra man hinh
            foreach (VeMB ve in ds)
                ve.Xuat();

            //tinh tong tien n ve
            float s = 0;
            foreach (VeMB ve in ds)
                s += ve;
            Console.WriteLine("\nTien ve TRUNG BINH: {0}", s / n);

            //dem so luong ve loai Business
            byte c = 0;
            foreach (VeMB ve in ds)
                if (ve.Loaive == "Business")
                    c++;
            Console.WriteLine("\nSo ve loai Business: {0}", c);
        }

        //bai 3.2 theo cach 2 class: VeMB va DS_VeMB
        static void BT3_2_c2()
        {
            DS_VeMB ds = new DS_VeMB();
            ds.Nhap();
            ds.SapXep();
            ds.XuatDS();
            ds.TinhTB();
            ds.DemLoaiVe();
        }

        static void BT3_3()
        {
            hoaDonHP hd = new hoaDonHP();
            hd.Nhap();
            hd.Xuat();
            hd.tongTC();
        }

        static void BT3_4()
        {
            Time time = new Time(4, 2, 58);
            Time t = new Time();
            t = time + 3600;
            t.Show();
        }

        static void BT3_5()
        {
            hocVien[] dshv;
            hocVien hv1 = new hocVien();
            float s = hv1 + 100;
            Console.WriteLine(s);
            byte n;
            do
            {
                Console.Write("Nhap n: ");
                n = byte.Parse(Console.ReadLine());

            } while (n > 2 && n < 20);
            dshv = new hocVien[n];
            for (int i = 0; i < n; i++)
            {
                dshv[i] = new hocVien();
                dshv[i].Nhap();
            }
            foreach (hocVien hv in dshv)
            {
                hv.Xuat();
            }
        }

            

        static void Main(string[] args)
        {

            BT3_4();
            byte chosse;
            Console.WriteLine("3_1 = phím 1 \n3_2 = phím 2\n3_3 = phím 3\n3_4 = phím 4\n3_5 = phím 5");
            Console.Write("Chọn câu: ");
            chosse = byte.Parse(Console.ReadLine());

            switch (chosse)
            {
                case 1:
                    BT3_1();
                    break;
                case 2:
                    BT3_2();
                    break;
                case 3:
                    BT3_3();
                    break;
                case 4:
                    BT3_4();
                    break;
                case 5:
                    BT3_5();
                    break;
            }

            //BT3_6
            //Cau a 9.5
            //Cau b Lỗi. Vì không thể gọi thuộc tính khi chưa đóng gói
            //Cau c Acer    1   7.5
            //Cau d Dell Latitude E7440    1   9.5 
            Console.ReadKey();  
        }
    }
}
