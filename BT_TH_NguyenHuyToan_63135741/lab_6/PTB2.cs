using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal class PTB2 : PTB1
    {
        float a;//ax^2+bx+c=0
        public PTB2(float a = 0, float b = 0, float c = 0) : base(b, c)
        {
            this.a = a;
        }
        //dung cho ung dung WF
        public new string Giai_WF()
        {
            if (a == 0)
                return base.Giai_WF();
            else
            {
                float del = b * b - (4 * a * c);
                if (del < 0)
                    return "PT vo nghiem";
                else if (del == 0)
                {
                    float x = -b / (2 * a);
                    return "PT co nghiem kep x1 = x2 = " + x;
                }
                else
                {
                    float x1 = (-b - (float)Math.Sqrt(del)) / (2 * a);
                    float x2 = (-b + (float)Math.Sqrt(del)) / (2 * a);
                    return $"PT co 2 nghiem PB = {x1} va {x2}";
                }
            }
        }

    }
}
