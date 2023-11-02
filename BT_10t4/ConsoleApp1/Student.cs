using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        int id;
        string name;
        DateTime birthday;
        bool male;

        // KHOI TAO KHONG THAM SO
        public Student()
        {
            this.id = 63135741;
            this.name = "Nguyễn Huy Toàn";
            this.birthday = new DateTime(14 / 03 / 2003);
            this.male = true;
        }

        // KHOI TAO CO THAM SO
        public Student(int id, string name, DateTime birthday, bool male)
        {
            this.id = id;
            this.name = name;
            this.birthday = birthday;
            this.male = male;
        }

        // SAO CHEP
        public Student(Student st)
        {
            this.id = st.id;
            this.name = st.name;
            this.birthday = st.birthday;
            this.male = st.male;
        }

        public void In()
        {
            Console.Write($"\nID: {id}");
            Console.Write($"\nTên: {name}");
            Console.Write($"\nGiới tính: {(male ? "Nam" : "Nữ")}");
            Console.Write($"\nTuổi: {TinhTuoi()} tuổi");
            Console.Write("\n");
        }

        private int TinhTuoi()
        {
            return DateTime.Now.Year - this.birthday.Year;
        }
    }
}
