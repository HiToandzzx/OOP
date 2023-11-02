using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class DSMayTinh
    {
        int n;
        MayTinh[] ds;
        public void Input()
        {
            Console.Write("Nhap so luong may tinh [2, 30]: ");

            while (!(int.TryParse(Console.ReadLine(), out n)) || n < 2 || n > 30)
            {
                Console.Write("Nhap lai n:");
            }

            ds = new MayTinh[n];

            for (int i=0; i<n; i++)
            {
                Console.WriteLine($"\nNhap thong tin may tinh thu {i + 1}:");
                Console.Write("Chon loai may tinh (1-Laptop, 2-Macbook): ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Laptop laptop = new Laptop();
                    laptop.NhapThongTin();
                    ds[i] = laptop;
                }
                else if (choice == 2)
                {
                    Macbook macbook = new Macbook();
                    macbook.NhapThongTin();
                    ds[i] = macbook;
                }
                else
                {
                    Console.WriteLine("Lua chon khong hop le!");
                    Console.WriteLine("Vui long chon lai!");
                    i--;
                }
            }
        }

        public void Print()
        {
            foreach (MayTinh mayTinh in ds)
            {
                mayTinh.XuatThongTin();
            }

        }

        public void Dem()
        {
            int soLuongLaptop = ds.Count(mayTinh => mayTinh is Laptop);
            int soLuongMacbook = ds.Count(mayTinh => mayTinh is Macbook);

            Console.WriteLine($"Ss luong Laptop: {soLuongLaptop}");
            Console.WriteLine($"So luong Macbook: {soLuongMacbook}");
        }
    }
}
