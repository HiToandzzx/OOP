using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GiaoVien : CanBo
    {
        int songaycong;
        int luongthang;
        public GiaoVien(string maso, string hoten, bool gioitinh, int songaycong, int luongthang) : base(maso, hoten, gioitinh)
        {
            this.songaycong = songaycong;
            this.luongthang = luongthang;
        }
        public double tinhLuong()
        {
            return songaycong * luongthang / 26;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Tính lương: {tinhLuong()}");
        }
    }
}
