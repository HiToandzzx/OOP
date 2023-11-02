using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng cán bộ: ");
            int n = int.Parse(Console.ReadLine());
            CanBo[] ds = new CanBo[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nNhập loại cán bộ (1: Nhân viên, 2: Giáo viên): ");
                int loaiCanBo = int.Parse(Console.ReadLine());

                Console.Write("Nhập mã số: ");
                string maso = Console.ReadLine();

                Console.Write("Nhập họ tên: ");
                string hoten = Console.ReadLine();

                Console.Write("Nhập giới tính: ");
                bool gioitinh = bool.Parse(Console.ReadLine());

                if (loaiCanBo == 1)
                {
                    Console.Write("Nhập số ngày công: ");
                    int songaycong = int.Parse(Console.ReadLine());

                    Console.Write("Nhập lương tháng: ");
                    int luongthang = int.Parse(Console.ReadLine());
                    ds[i] = new NhanVien(maso, hoten, gioitinh, songaycong, luongthang);
                }
                else if (loaiCanBo == 2)
                {
                    Console.Write("Nhập số tiết giảng: ");
                    int sotietgiang = int.Parse(Console.ReadLine());

                    Console.Write("Nhập thù lao tiết giảng: ");
                    int thulao = int.Parse(Console.ReadLine());

                    ds[i] = new GiaoVien(maso, hoten, gioitinh, sotietgiang, thulao);
                }
                else
                {
                    Console.WriteLine("Loại cán bộ không hợp lệ!");
                    i--;
                }
            }
            for (int i = 0; i<n; i++)
            {
                Console.WriteLine("\n==============");
                Console.WriteLine($"\nCán bộ thứ {i+1}");
                ds[i].xuat();
            }
            Console.ReadKey();
        }
    }
}

