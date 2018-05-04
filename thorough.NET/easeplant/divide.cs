using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easeplant
{
   public class divide:zong
    {
       public override int Calc()
       {
           if (this.NumRight == 0)
           {
               //程序如何抛出异常
               throw new Exception("除数不能为0");
           }
           else
           {
               return this.NumLift / this.NumRight;
           }
       }
    }
}
