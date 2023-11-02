using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Chuoi
    {
        string s;
        int x, y; //Vi tri xuat hien cua chuoi s

        public Chuoi()
        {
            s = "Huy Toan dep trai nhat xom vip pro no1";
            x = 7;
            y = 2;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public Chuoi(string s, int x, int y, int bg, int fg)
        {
            this.s = s;
            this.x = x;
            this.y = y;
            Console.BackgroundColor = (ConsoleColor) bg;
            Console.ForegroundColor = (ConsoleColor) fg;
        }

        //HIEN THI
        public void Output()
        {
            Console.Clear(); //Xoa text tren man hinh
            Console.CursorLeft = x; //Dua con tro toi cot x
            Console.CursorTop = y; //Dua con tro toi dong y
            Console.CursorVisible = false; //An con tro
            Console.Write(s);
        }

        //MOVE 
        public void Move()
        {
            Output();

            while (true)
            {
                ConsoleKeyInfo button = Console.ReadKey();

                if (button.Key == ConsoleKey.Escape)
                    break;

                if (button.Key == ConsoleKey.LeftArrow) //Mui ten trai
                    x--;
                if (button.Key == ConsoleKey.RightArrow) //Mui ten phai
                    x++;
                if (button.Key == ConsoleKey.UpArrow) //Mui ten len
                    y--;
                if (button.Key == ConsoleKey.DownArrow) //Mui ten xuong
                    y++;

                //Xu li duong bien


                Output();
            }  
        }
    }
}
