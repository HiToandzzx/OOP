using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Program
    {
        static void bai2_1()
        {
            //TAO DOI TUONG DUNG` KHOI TAO KHONG THAM SO
            Point point1 = new Point();
            Console.WriteLine("Nhập vào tọa độ x, y: ");
            short a = short.Parse(Console.ReadLine());
            short b = short.Parse(Console.ReadLine());
            Point point2 = new Point(a, b);

            point1.Output();
            point2.Output();

            Console.WriteLine("Khoảng cách từ A đên B: {0}", point1.Distance(point2));
        }

        static void bai2_2() 
        {
            Circle circle = new Circle();

            Console.WriteLine($"def obj: Chu vi = {circle.GetPerimeter()}, Diện tích = {circle.GetArea()}");

            Console.WriteLine("Nhập vào bán kính R khác: ");
            float r = float.Parse(Console.ReadLine());
            circle.SetRadius(r);
            Console.WriteLine($"new obj: Chu vi = {circle.GetPerimeter()}, Diện tích = {circle.GetArea()}");

        }

        static void bai2_3()
        {
            Chuoi c = new Chuoi();
            c.Move();
        }
        static void bai2_4()
        {
            Adult a1 = new Adult();
            a1.Info();
            a1.Inc_Dec_W();
        }

        static void bai2_5()
        {
            Student student = new Student();
            student.Print();
        }
        static void bai2_6()
        {
            //Không tham số
            Time time1 = new Time();
            Console.Write($"Time Without Parameters: ");
            time1.Show();

            //Tính móc tg sau 1s, thuộc tính đóng gói
            Time time2 = time1.NextSecond();
            Console.Write($"\nTime Without Parameters After 1s: {time2.Hour}:{time2.Minute}:{time2.Second}");

            //Có tham số
            Time time3 = new Time(05, 15, 61);
            Console.Write($"\n\nTime With Parameters: ");
            time3.Show();

            //Tính móc tg sau 1s, thuộc tính đóng gói
            Time time4 = time3.PreviousSecond();
            Console.Write($"\nTime With Parameters Before 1s: ");
            time4.Show();
        }

        static void bai2_7()
        {
            Console.WriteLine("Câu a: 0+0=0");
            Console.WriteLine("Câu b: 7+8=15");
            Console.WriteLine("Câu c: Lỗi!");
            Console.WriteLine("Câu d: 7+8=15");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            byte chosse;
            Console.WriteLine("2_1 = phím 1 \n2_2 = phím 2\n2_3 = phím 3\n2_4 = phím 4\n2_5 = phím 5\n2_6 = phím 6\n2_7 = phím 7");
            Console.Write("Chọn câu: ");
            chosse = byte.Parse(Console.ReadLine());

            switch (chosse)
            {
                case 1:
                    bai2_1(); 
                    break;
                case 2:
                    bai2_2();
                    break;
                case 3:
                    bai2_3();
                    break;
                case 4:
                    bai2_4();
                    break;
                case 5:
                    bai2_5();
                    break;
                case 6:
                    bai2_6();
                    break;
                case 7:
                    bai2_7();
                    break;
                    
            }
            Console.ReadKey();
        }
    }
}
