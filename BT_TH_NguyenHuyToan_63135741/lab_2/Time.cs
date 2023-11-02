using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Time
    {
        int hour, minute, second;
        public Time()
        {
            hour = 03;
            minute = 13;
            second = 0;
        }

        public Time(int h, int m, int s)
        {
            this.hour = h;
            this.minute = m;
            this.second = s;
        }

        //Đóng gói thuộc tính
        public int Hour { get => hour; set => hour = value; }
        public int Minute { get => minute; set => minute = value; }
        public int Second { get => second; set => second = value; }

        //Tính tg sau 1s
        public Time NextSecond()
        {
            Time next = new Time(this.hour, this.minute, this.second + 1);
            if (next.second == 60)
            {
                next.minute += 1;
                next.second = 0;
            }
            if (next.minute == 60)
            {
                next.hour += 1;
                next.minute = 0;
            }
            if (next.hour == 24)
            {
                next.hour = 0;
            }
            return next;
        }

        //Tính tg trước 1s
        public Time PreviousSecond()
        {
            Time prev = new Time(this.hour, this.minute, this.second - 1);
            if (prev.second == -1)
            {
                prev.minute -= 1;
                prev.second = 59;
            }
            if (prev.minute == -1)
            {
                prev.hour -= 1;
                prev.minute = 59;
            }
            if (prev.hour == -1)
            {
                prev.hour = 23;
            }
            return prev;
        }

        public void Show()
        {
            Console.WriteLine($"{hour}:{minute}:{second}");
        }
    }
}
