using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal class PTB1
    {
        protected float b, c;//bx+c=0
        //khoi tao
        public PTB1(float b = 0, float c = 0)
        {
            this.b = b; this.c = c;
        }
        //dung cho ung dung WF
        public string Giai_WF()
        {
            if (b == 0)
                if (c == 0)
                    return "PT vo so nghiem!";
                else
                    return "PT vo nghiem!";
            else
            {
                float x = -c / b;
                return "PT co nghiem x = " + x;
            }
        }

    }
}
