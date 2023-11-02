using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DanhSach
    {
        List<Student> ds;
        int n;

        public DanhSach()
        {
            try
            {
                FileStream f = new FileStream("C:\\Users\\Admin\\Desktop\\S\\OOP\\BT_10t4\\input.txt", FileMode.Open, FileAccess.Read);
                StreamReader rd = new StreamReader(f, Encoding.UTF8);

                // DOC VA HIEN THI
                n = int.Parse(rd.ReadLine());
                ds = new List<Student>(n);
                for (int i=0; i<n; i++)
                {
                    int id = int.Parse(rd.ReadLine());
                    string name = rd.ReadLine();
                    DateTime birthday = DateTime.Parse(rd.ReadLine());
                    bool male = bool.Parse(rd.ReadLine());
                    Student s = new Student(id, name, birthday, male);
                    ds.Add(s);
                }
                f.Close();
            }
            catch
            {
                Console.WriteLine("File not found!");
            }
        }
        public void Xoa(int x)
        {
            ds.RemoveAt(x);
        }

        public void Xuat()
        {
            foreach (Student s in ds)
            {
                s.In();
            }
        }
    }
}
}
