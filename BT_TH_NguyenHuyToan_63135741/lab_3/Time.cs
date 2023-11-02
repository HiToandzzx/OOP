using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class Time
    {
        int hour, minute, second;
        public Time()
        {
            hour = 0;
            minute = 0;
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

        public static Time operator ++(Time t)
        {
            return t.NextSecond();
        }

        public static Time operator --(Time t)
        {
            return t.PreviousSecond();
        }

        //tính và trả về mốc thời gian được cộng thêm s giây.
        public static Time operator +(Time t2, int s)
        {
            int value = t2.second + s;
            if (value >= 60)
            {
                int minute = value / 60;
                int second = value % 60;
                t2.second = second;
                minute += t2.minute;

                // Xư lý phút
                if (minute >= 60)
                {
                    int hour = minute / 60;
                    minute = minute % 60;
                    t2.hour += hour;
                    t2.hour = minute;
                }
                else
                {
                    t2.minute += minute;
                }
                return t2;
            }
            else
            {
                t2.second = value;
                return t2;
            }
        }

        public void Show()
        {
            Console.WriteLine($"{hour}:{minute}:{second}");
        }
    }
}

