using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    interface IHocPhi
    {
        double TienHocPhi { get; set; }
        double TinhTienGiamHocPhi();
    }

    class HocVien : IHocPhi
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DoiTuong { get; set; }
        public double TienHocPhi { get; set; }

        public HocVien() { }

        public HocVien(string maSo, string hoTen, DateTime ngaySinh, string doiTuong, double tienHocPhi)
        {
            MaSo = maSo;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DoiTuong = doiTuong;
            TienHocPhi = tienHocPhi;
        }

        public void NhapThongTin()
        {
            Console.Write("\nNhap ma so: ");
            MaSo = Console.ReadLine();
            Console.Write("\nNhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("\nNhap ngay sinh (dd/mm/yyyy): ");
            NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.Write("\nNhap doi tuong: ");
            DoiTuong = Console.ReadLine();
            Console.Write("\nNhap  hoc phi: ");
            TienHocPhi = double.Parse(Console.ReadLine());
        }

        public double TinhTienGiamHocPhi()
        {
            double tienGiam = 0;
            if (DoiTuong == "Ho Ngheo")
            {
                return tienGiam = TienHocPhi;
            }
            else if (DoiTuong == "Can Ngheo")
            {
                return tienGiam = TienHocPhi * 0.5;
            }
            else return tienGiam;
        }
        public double TienHocPhiPhaiDong()
        {
            double tiendong = TienHocPhi - TinhTienGiamHocPhi();
            return tiendong;
        }
        public void Xuat_F()
        {
            Console.WriteLine($"MS: {MaSo}\tHo ten: {HoTen}\t Ngay Sinh: {NgaySinh}\t Doi Tuong: {DoiTuong}\t Tien HP phai dong: {TienHocPhiPhaiDong()}");
        }
    }

    class HocVienComparer : IComparer<HocVien>
    {
        public int Compare(HocVien x, HocVien y)
        {
            if (x.TienHocPhiPhaiDong() == y.TienHocPhiPhaiDong())
            {
                return 0;
            }
            else if (x.TienHocPhiPhaiDong() > y.TienHocPhiPhaiDong())
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
    class KhoaHoc
    {
        string tenKhoaHoc;
        int soLuongHocVien;
        List<HocVien> dsHocVien;

        public KhoaHoc()
        {
            dsHocVien = new List<HocVien>();
        }
        void DocFile()
        {
            try
            {
                FileStream f = new FileStream("HocPhi.txt", FileMode.Open, FileAccess.Read);
                StreamReader rd = new StreamReader(f);
                string line;//luu du lieu doc tung dong tu file ra chuong trinh
                while ((line = rd.ReadLine()) != null)//con dong du lieu trong file
                {
                    string[] fields = line.Split(';');
                    if (fields.Length == 5)
                    {
                        string maSo = fields[0];
                        string hoTen = fields[1];
                        DateTime ngaySinh = DateTime.Parse(fields[2]);
                        string doiTuong = fields[3];
                        float tienHocPhi = float.Parse(fields[4]);
                        HocVien hv = new HocVien(maSo, hoTen, ngaySinh, doiTuong, tienHocPhi);
                        dsHocVien.Add(hv);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void NhapKhoaHoc()
        {
            Console.Write("\nNhap ten khaa hoc: ");
            tenKhoaHoc = Console.ReadLine();
            Console.Write("Nhap so luong hoc vien: ");
            soLuongHocVien = int.Parse(Console.ReadLine());
            dsHocVien = new List<HocVien>();
            DocFile();
        }

        private List<HocVien> NhapDanhSachHocVien(int soLuong)
        {
            List<HocVien> ds = new List<HocVien>();
            for (int i = 0; i < soLuong; i++)
            {
                HocVien hv = new HocVien();
                hv.NhapThongTin();
                ds.Add(hv);
            }
            return ds;
        }
        public void Xuat()
        {
            Console.WriteLine($"Ten KH: {tenKhoaHoc}\tSLHV:{soLuongHocVien}");
            Console.WriteLine("Danh sach hoc vien: ");
            foreach (HocVien hv in dsHocVien)
                hv.Xuat_F();
        }

        public void XuatDanhSachHocVienTheoHocPhi()
        {
            dsHocVien.Sort(new HocVienComparer());
            Console.WriteLine($"\nDanh sach hoc vien khoa hoc {tenKhoaHoc}:");
            foreach (HocVien hv in dsHocVien)
            {
                hv.Xuat_F();
            }
        }

        public void TimHocVien(string maSo)
        {
            HocVien hv = dsHocVien.Find(x => x.MaSo == maSo);
            if (hv != null)
            {
                hv.Xuat_F();
            }
            else
            {
                Console.WriteLine($"Khong tim thay hoc vien co ma so {maSo}!");
            }
        }

        public void XoaHocVien()
        {
            dsHocVien.RemoveAll(hv => hv.TienHocPhiPhaiDong() == 0);
        }

        public void ThemHV()
        {
            HocVien hocVien = new HocVien();
            hocVien.NhapThongTin();
            dsHocVien.Add(hocVien);
        }

    }
}
