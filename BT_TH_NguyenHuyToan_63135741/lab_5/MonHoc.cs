using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    class MonHoc
    {
        string ma, ten;
        byte sotc;
        float tlkt, dkt, tlgk, dgk, dthi;
        
        public MonHoc()
        {
            ma = "SOT331"; 
            ten = "LTHDT";
            sotc = 3; 
            tlkt = 0.3f; 
            dkt = 6.5f;
            tlgk = 0.3f; 
            dgk = 8.7f; 
            dthi = 9;
        }
        public MonHoc(string m, string t, byte tc, float tlkt, float dkt, float tlgk, float dgk, float dt)
        {
            ma = m; 
            ten = t; 
            sotc = tc;
            this.tlkt = tlkt; 
            this.dkt = dkt; 
            this.tlgk = tlgk; 
            this.dgk = dgk; 
            this.dthi = dt;
        }

        public byte Sotc { get => sotc; set => sotc = value; }
        public float Dthi { get => dthi; set => dthi = value; }
        
        // TINH DIEM TB MON
        public float TBMonHoc()
        {
            return tlkt * dkt + tlgk * dgk + (1 - tlkt - tlgk) * dthi;
        }

        // XUAT
        public void Xuat()
        {
            Console.WriteLine($"{ten}\tKT:{dkt}\tGK:{dgk}\tCK:{dthi}\tTB:{TBMonHoc()}");
        }

        // KIEM TRA DU LIEU DOC TU FILE
        public void Xuat_F()
        {
            Console.WriteLine($"{ma}\t{ten}\t{sotc}\t{tlkt}\t{dkt}\t{tlgk}\t{dgk}\t{dthi}");
        }
    }

    // LOP SINH VIEN
    class Sinhvien
    {
        string mssv, hoten;
        List<MonHoc> ls;

        void DocFile()
        {
            try
            {
                FileStream f = new FileStream("MonHoc.txt", FileMode.Open, FileAccess.Read);
                StreamReader rd = new StreamReader(f);
                string line;//luu du lieu doc tung dong tu file ra chuong trinh
                while ((line = rd.ReadLine()) != null)//con dong du lieu trong file
                {
                    string[] item = line.Split(';');//8 phan tu trong item
                    string m = item[0];
                    string t = item[1];
                    byte tc = byte.Parse(item[2]);
                    float tlkt = float.Parse(item[3]);
                    float dkt = float.Parse(item[4]);
                    float tlgk = float.Parse(item[5]);
                    float dgk = float.Parse(item[6]);
                    float dt = float.Parse(item[7]);
                    MonHoc mh = new MonHoc(m, t, tc, tlkt, dkt, tlgk, dgk, dt);
                    ls.Add(mh);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Nhap()
        {
            Console.Write("\nNhap mssv: ");
            mssv = Console.ReadLine();
            Console.Write("\nNhap ho ten: ");
            hoten = Console.ReadLine();

            // KHOI TAO DANH SACH CAC MON HOC
            ls = new List<MonHoc>();

            // DOC DU LIEU TU FILE
            DocFile();
        }

        // TINH DIEM TRUNG BINH HOC KI
        public float TBHK()
        {
            float s = 0;
            int tc = 0;
            foreach (MonHoc mh in ls)
            {
                s = s + mh.TBMonHoc() * mh.Sotc;
                tc = tc + mh.Sotc;
            }
            return s / tc;
        }

        // XEM XET DIEU KIEN HOC BONG
        bool KT()
        {
            foreach (MonHoc mh in ls)
                if (mh.TBMonHoc() < 5.5f || mh.Dthi < 5.5)
                    return false;
            return true;
        }

        public bool XetHB()
        {
            if (TBHK() > 7 && KT())
                return true;
            return false;
        }

        // XUAT
        public void Xuat()
        {
            Console.WriteLine($"{mssv}\t{hoten}");
            Console.WriteLine("\nDanh sach cac mon hoc: ");
            foreach (MonHoc mh in ls)
                mh.Xuat_F();
            Console.WriteLine($"\nTB hoc ky: {TBHK()}");
        }
    }
}
