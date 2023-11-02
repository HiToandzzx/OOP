using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Program
    {

        // BAI 4_1
        static void BT4_1()
        {
            PTB1 pt1 = new PTB1();
            pt1.Nhap();
            pt1.Xuat();
            pt1.Giai();

            Console.WriteLine("\nNhap vao he so a, b, c cho PTB2:");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            PTB2 pt2 = new PTB2(a, b, c);
            pt2.Xuat();
            pt2.Giai();
        }
        // BAI 4_2
        static void BT4_2()
        {
            List_SmartPhone ls = new List_SmartPhone();
            ls.Input();
            Console.Write("\nDanh sach n smartphone: \n");
            ls.Print();
            ls.Add();
            Console.Write("\nDanh sach smartphone sau khi them: \n");
            ls.Print();
            ls.Delete();
            Console.Write("\nDanh sach smartphone sau khi xoa: \n");
            ls.Print();
            ls.Sort();
            Console.Write("\nDanh sach smartphone sau sap xep: \n");
            ls.Print();
        }

        // BAI 4_3
        static void BT4_3()
        {
            List_Shape ls = new List_Shape();
            ls.Input();
            ls.Print();
            Console.WriteLine($"Dien tich TB:{ls.Avg_Area()}");
        }


        // BAI 4_4
        static void BT4_4()
        {
            Console.Write("Chon loai may tinh (1-Laptop, 2-Macbook): ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                // Nhập thông tin Laptop
                Laptop laptop = new Laptop();
                laptop.NhapThongTin();
                laptop.TinhGiaBan();
                laptop.XuatThongTin();
            }
            else if (choice == 2)
            {
                // Nhập thông tin Macbook
                Macbook macbook = new Macbook();
                macbook.NhapThongTin();
                macbook.TinhGiaBan();
                macbook.XuatThongTin();
            }
            else
            {
                Console.WriteLine("Lua chon khong hop le!");
            }

            DSMayTinh ds = new DSMayTinh();
            ds.Input();
            ds.Print();
            ds.Dem();
        }


        // BAI 4_5
        static void Bai4_5()
        {
            Console.WriteLine("Câu a: 3 5 7");
            Console.WriteLine("Câu b: 2 4");
            Console.WriteLine("Câu c: 1 4");
            Console.WriteLine("Câu d: 1 5 7");
            Console.WriteLine("Câu e: 1 2 7");
        }

        // MAIN
        static void Main(string[] args)
        {
            BT4_4();
            Console.ReadKey();
        }
    }
}
