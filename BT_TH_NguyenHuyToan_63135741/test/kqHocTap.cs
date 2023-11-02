using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class kqHocTap
    {
        string maHP, tenHP;
        float DTB;
        byte soTC;

        public void Nhap()
        {
            Console.WriteLine("Nhập mã HP: ");
            maHP = Console.ReadLine();
            Console.WriteLine("Nhập tên HP: ");
            tenHP = Console.ReadLine();
            Console.WriteLine("Nhập DTB của HP: ");
            DTB = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số TC của HP: ");
            soTC = byte.Parse(Console.ReadLine());
        }


        public kqHocTap(string maHP, string tenHP, float DTB, byte soTC)
        {
            this.maHP = maHP;
            this.tenHP = tenHP;
            this.DTB = DTB;
            this.soTC = soTC;
        }
    }

    class SinhVien
    {
        string id, name;
        bool sex;
        static short tongTC = 147; //Dùng chung
        short n; //Số HP

        kqHocTap[] dshp;


        public void Nhap()
        {
            Console.WriteLine("Nhập MSSV của SV: ");
            id = Console.ReadLine();
            Console.WriteLine("Nhập tên của SV: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhập giới tính của SV: ");
            sex = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Nhập số HP: ");
            n = Convert.ToInt16(Console.ReadLine());

            dshp = new kqHocTap[n];
            for(int i=0; i<n; i++)
            {
                dshp[i] = new kqHocTap();
                dshp[i].Nhap();
            }
        }

        public SinhVien(string id, string name, bool sex)
        {
            this.id = id;
            this.name = name;
            this.sex = sex;
        }   


    }


}
