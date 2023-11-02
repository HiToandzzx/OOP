using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class Program
    {

        // BAI 5.1
        static void BT5_1()
        {
            List_Rec ls = new List_Rec();
            Console.Write("\nDanh sach n hinh chu nhat: ");
            ls.Input();

            ls.Sort();
            Console.Write("\nDanh sach HCN sau khi sx: ");  
            ls.Print();

            ls.Add();
            Console.Write("\nDanh sach HCN sau khi xoa: ");
            ls.Print();

            ls.Del();
            Console.Write("\nDanh sach HCN sau khi xoa: ");
            ls.Print();

            Console.Write("\nTong chi phi: {0} ", ls.Sum_Cost());
        }

        // BAI 5.2
        static void BT5_2()
        {
            Sinhvien sv = new Sinhvien();
            sv.Nhap();
            sv.Xuat();
            if (sv.XetHB())
                Console.Write("\nSV du dieu kien xet HB");
            else
                Console.Write("\nSV khong du dieu kien xet HB");
        }

        // BAI 5.3
        static void BT5_3()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            // TAO KHOA HOC
            KhoaHoc kh = new KhoaHoc();
            kh.NhapKhoaHoc();
            kh.Xuat();

            // XUAT DANH SACH HOC VIEN THEO HOC PHI GIAM DAN
            Console.WriteLine("\nDanh sach hoc vien theo hoc phi giam dan: ");
            kh.XuatDanhSachHocVienTheoHocPhi();

            // TIM HOC VIEN THEO MA SO
            Console.WriteLine("\nNhap ma so hoc vien can tim: ");
            string maSoHV = Console.ReadLine();
            kh.TimHocVien(maSoHV);

            // THEM HOC VIEN MOI
            Console.Write("\nNhap thong tin hoc vien can them!");
            kh.ThemHV();
            Console.WriteLine("\nDanh sach hoc vien sau khi them: ");
            kh.Xuat();

            // XOA HOC VIEN CO HOC PHI = 0
            kh.XoaHocVien();
            // XUAT DANH SACH HOC VIEN SAU KHI XOA
            Console.Write("\nDanh sach hoc vien sau khi xaa các hoc vien co tien hoc phi bang 0:");
            kh.Xuat();
        }

        // BAI 5.4
        static void BT5_4()
        {
            ListNews listNews = new ListNews();
            listNews.Input();
            listNews.Output();
            int choice = 0;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Them tin tuc");
                Console.WriteLine("2. Xem danh sach tin tuc");
                Console.WriteLine("3. Danh gia");
                Console.WriteLine("4. Exit");
                Console.Write("Nhap lua chon cua ban: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        listNews.Insert_News();
                        break;
                    case 2:
                        listNews.Output();
                        break;
                    case 3:
                        listNews.Output();
                        listNews.AverageRate();
                        break;
                    case 4:
                        Console.WriteLine("\nTam biet!");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le, hay nhap lai!");
                        break;
                }
            } while (choice != 4) ;
        }

        static void Main(string[] args)
        {
            BT5_4();
            Console.ReadKey();
        }
    }
}
