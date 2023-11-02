using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CanBo
    {
        string maso;
        string hoten;
        bool gioitinh;
        public CanBo(string maso, string hoten, bool gioitinh)
        {
            this.maso = maso;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
        }
        public double tinhLuong()
        {
            return 0;
        }

        public virtual void xuat()
        {
            Console.WriteLine($"Mã số: {maso} \nHọ tên: {hoten} \nGiới tính: {(gioitinh ? "Nam" : "Nữ")}");
        }
    }
}
