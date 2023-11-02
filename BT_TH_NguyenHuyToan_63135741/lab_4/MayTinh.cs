using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal abstract class MayTinh
    {
        protected string nhanHieu;
        protected int ram;
        protected int boNho;
        protected double giaNhap;

        public MayTinh()
        {
            nhanHieu = "Acer Nitro 5";
            ram = 16;
            boNho = 512;
            giaNhap = 23000000;
        }

        public MayTinh(string nhanHieu, int ram, int boNho, double giaNhap)
        {
            this.nhanHieu = nhanHieu;
            this.ram = ram;
            this.boNho = boNho;
            this.giaNhap = giaNhap;
        }

        public virtual void NhapThongTin()
        {
            Console.Write("Nhap nhan hieu may tinh: ");
            nhanHieu = Console.ReadLine();
            Console.Write("Nhap RAM: ");
            ram = int.Parse(Console.ReadLine());
            Console.Write("Nhap bo nho: ");
            boNho = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia nhap: ");
            giaNhap = double.Parse(Console.ReadLine());
        }

        public abstract double TinhGiaBan();

        public virtual void XuatThongTin()
        {
            Console.WriteLine($"Nhan hiệu: {nhanHieu} \t RAM: {ram}GB \t Bo nho: {boNho}GB \t Gia ban: {TinhGiaBan()} VND");
        }
    }

    // LOP LAPTOP KE THUA TU LOP MAY TINH
    internal class Laptop : MayTinh
    {
        protected double trongLuong;

        public Laptop()
        {
            trongLuong = 2.1;
        }

        public Laptop(string nhanHieu, int ram, int boNho, double giaNhap, double trongLuong) : base(nhanHieu, ram, boNho, giaNhap)
        {
            this.trongLuong = trongLuong;
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap trong luong may tinh: ");
            trongLuong = double.Parse(Console.ReadLine());
        }

        public override double TinhGiaBan()
        {
            if (trongLuong >= 2)
            {
                return giaNhap + giaNhap * 0.15;
            }
            else
            {
                return giaNhap + giaNhap * 0.2;
            }
        }
    }

    // LOP MACBOOK KE THUA TU LOP MAY TINH
    internal class Macbook : MayTinh
    {
        protected string loai;

        public Macbook() { }

        public Macbook(string nhanHieu, int ram, int boNho, double giaNhap, string loai) : base(nhanHieu, ram, boNho, giaNhap)
        {
            this.loai = loai;
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap loai Macbook (MacBook Air / MacBook Pro 13 inch / MacBook Pro 16 inch): ");
            loai = Console.ReadLine();
        }

        public override double TinhGiaBan()
        {
            if (loai == "MacBook Air")
            {
                return giaNhap + giaNhap * 0.5;
            }
            else if (loai == "MacBook Pro 13 inch")
            {
                return giaNhap + giaNhap * 0.8;
            }
            else if (loai == "MacBook Pro 16 inch")
            {
                return 2 * giaNhap;
            }
            return giaNhap;
        }
    }
}
