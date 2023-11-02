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
            DanhSach SinhVien = new DanhSach();
            Console.WriteLine("Danh sách sinh viên:");
            SinhVien.Xuat();
            Console.WriteLine("Danh sách sinh viên sau khi xóa:");
            SinhVien.Xoa(1);
            SinhVien.Xuat();
            Console.ReadKey();
        }
    }
}
