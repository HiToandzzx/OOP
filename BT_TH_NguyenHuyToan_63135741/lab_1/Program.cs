using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    internal class Program
    {
        static void bai1_1(){
            string hoTen;
            DateTime ngayThang;
            bool gioiTinh;

            //Input
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap ngay thang nam sinh: ");
            ngayThang = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Nhap gioi tinh: ");
            gioiTinh = bool.Parse(Console.ReadLine());

            //Output
            if (gioiTinh)
                Console.WriteLine($"{hoTen}\t{ngayThang.ToShortDateString()}\t Nam");
            else
                Console.WriteLine($"{hoTen}\t{ngayThang.ToShortDateString()}\t Nu");
        }

        static void bai1_2(){
            short a, b, c;
            //input
            Console.Write("Nhap vao 3 so nguyen: ");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            c = Convert.ToInt16(Console.ReadLine());

            //output
            if (a <= b && b <= c)
                Console.WriteLine("increasing");
            else if (a >= b && b >= c)
                Console.WriteLine("decreasing");
            else
                Console.WriteLine("neither increasing nor decreasing order");
        }

        static void bai1_3(){
            char c;
            short a, b;

            //input
            Console.Write("Nhap vao 3 so nguyen: ");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap toan tu: ");
            c = char.Parse(Console.ReadLine());

            //output
            switch (c){
                case '+':
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case '-':
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case '*':
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case '/':
                    Console.WriteLine($"{a} / {b} = {a / b}");
                    break;
                default:
                    Console.WriteLine($"{c} khong la toan tu");
                    break;
            }
        }

        static void bai1_4(){
            short key = 123;
            short pass;
            byte c = 0;

            Console.Write("Nhap mat khau: ");
            do{
                if (c > 0)
                    Console.Write("Nhap lai: ");
                pass = Convert.ToInt16(Console.ReadLine());
                c++;
                if (pass == key){
                    Console.WriteLine("Dang nhap thanh cong!");
                    break;
                }
                else  
                    Console.WriteLine("Dang nhap khong thanh cong!");
            }while (c <= 3);
        }

        static void hoanDoi(ref int a, ref int b){
            int temp = a;
            a = b;
            b = temp;
        }

        static bool ktSNT(int x){
            byte count = 0;
            if(x<2)
                    return false;
            for(int i=1; i<=x; i++)
                if(x%i==0)
                    count++;
            if(count==2)
                    return true;
            return false;
             
        }

        static void bai1_5(){
            byte n;
            int[] a;
            do{
                Console.Write("Nhap so luong phan tu trong day: ");
                n = byte.Parse(Console.ReadLine());
            }while (n < 3 || n > 20);

            // KHOI TAO MANG
            a = new int[n];
            for (int i = 0; i < n; i++){
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
           
            //SAP XEP
            for(int i=0; i<n; i++)
                for(int j=i+1; j<n; j++)
                    if(a[i] > a[j])
                        hoanDoi(ref a[i], ref a[j]);

            Console.Write("Sap xep tang dan: ");
            foreach (int x in a)
                Console.Write($"{x}\t");

            //DEM SO NT TRONG MANG
            byte count = 0;
            for(int i=0; i<n; i++)
                if (ktSNT(a[i]))
                    count++;
            Console.WriteLine($"\nCo {count} so nguyen to trong mang");
        }

        //KT NAM NHUAN
        static bool ktNamNhuan(int y)
        {
            if ((y % 4) == 0 && (y % 100) != 0)
                return true;
            else if ((y % 400) == 0)
                return true;
            else
                return false;
        }
        static void bai1_6(){
            int y;
            int m;
            do
            {
                Console.Write("Nhap nam bat ki: ");
                y = Convert.ToInt16(Console.ReadLine());
            } while (y<0);

            do
            {
                Console.Write("Nhap thang bat ki: ");
                m = Convert.ToInt16(Console.ReadLine());
            } while (m < 0 || m > 12);

            if (ktNamNhuan(y))
                Console.Write($"{y} la nam Nhuan");
            else
                Console.Write($"{y} khong la nam Nhuan");

            switch (m)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    Console.Write($" va thang {m} co 31 ngay!");
                    break;
                case 4: case 6: case 9: case 11:
                    Console.Write($" va thang {m} co 30 ngay!");
                    break;
                case 2:
                    Console.Write($" va thang {m} co 29 ngay!");
                    break;
            }
        }

        static void bai1_7(){
            Console.Write("TRÒ CHƠI BUA - KEO - BAO\n");
            Console.Write("Chon 1 la BUA\n");
            Console.Write("Chon 2 la KEO\n");
            Console.Write("Chon 3 la BAO\n");
            Console.Write("======================\n");

            int n, LuaChon;
            do{
                //NHẬP
                do{
                    Console.Write("\nMoi ban chon: ");
                    n = Convert.ToInt16(Console.ReadLine());

                    if (n == 1)
                        Console.WriteLine("\nBan da chon BUA");
                    else if (n == 2)
                        Console.WriteLine("\nBan da chon KEO");
                    else if (n == 3)
                        Console.WriteLine("\nBan da chon BAO");
                    else
                        Console.WriteLine("\nHay chon lai!");
                }while (n < 1 || n > 3);

                //HÀM RANDOM
                Random rd = new Random();
                int bot = rd.Next(1,4);
                switch (bot){
                    case 1:
                        Console.WriteLine("May da chon BUA");
                        break;
                    case 2:
                        Console.WriteLine("May da chon KEO");
                        break;
                    case 3:
                        Console.WriteLine("May da chon BAO");
                        break;
                }

                //XÉT ĐIỀU KIỆN
                if (n == bot)
                    Console.WriteLine("KET QUA: DRAWN");
                else if (n == 1 && bot == 3 || n == 2 && bot == 1 || n == 3 && bot == 2)
                    Console.WriteLine("KET QUA: LOSE");
                else if (n == 3 && bot == 1 || n == 1 && bot == 2 || n == 2 && bot == 3)
                    Console.WriteLine("KET QUA: WIN");

                //XUẤT
                do{
                    Console.Write("\nPLAY AGAIN?\n");
                    Console.Write("1: YES \n2: NO  \n");
                    LuaChon = int.Parse(Console.ReadLine());
                    if (LuaChon < 1 || LuaChon > 2)
                        Console.WriteLine("Choose again!");
                }while (LuaChon < 1 || LuaChon > 2);
            }while (LuaChon != 2);
        }

        static void bai1_8()
        {
            Console.WriteLine("a: 15, 10");
            Console.WriteLine("b: 1, 0");
            Console.WriteLine("c: Error phải sửa thành int a = int.Parse(Console.ReadLine());");
            Console.WriteLine("d: Error chưa gán giá trị cho biến chk và sai chính tả ");
            Console.WriteLine("e: 1");
        }
        static void Main(string[] args)
            {
                bai1_6();
                Console.ReadKey();
            }
    }
}



