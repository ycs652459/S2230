using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thorought.NET.xiangm
{
    class PM
    {
        public void Judge(SE se, string grade, int manager)
        {
            se.Grade = grade;//更改的值赋给SE的值中
            se.Manager = manager;
        }
    }
}
