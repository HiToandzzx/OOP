using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Student
    {
        int id;
        string name;
        bool sex;
        DateTime ngayThang;

        

        public Student()
        {
            Console.Write("Nhập MSSV: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Nhập họ tên: ");
            name = Console.ReadLine();
            Console.Write("Nhập ngày tháng năm sinh: ");
            ngayThang = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Nhập giới tính: ");
            sex = bool.Parse(Console.ReadLine());
        }


        
        public Student(int id, string name, bool sex, DateTime ngayThang)
        {
            this.id = id;
            this.name = name;
            this.sex = sex;
            this.ngayThang = ngayThang;
        }

        public Student(Student student)
        {
            id = student.id;
            name = student.name; 
            sex = student.sex;
            ngayThang = student.ngayThang;
        }


        public void Print() 
        {
            Console.WriteLine("\n===== Thông tin sinh viên =====");
            Console.WriteLine($"MSSV: {id}");
            Console.WriteLine($"Họ và tên: {name}");
            if(sex)
                Console.WriteLine($"Giới tính: Nam");
            else
                Console.WriteLine($"Giới tính: Nu");
            Console.WriteLine($"Ngày tháng năm sinh: {ngayThang}");
            Console.ReadKey();
        }
    }
}
