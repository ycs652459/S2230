using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_shangji1
{
    //继承SE，实现Iflay
   public class PM:SE,Iflay
    {
       public void Fun()
       {
           Console.WriteLine("吓尿泡");
       }
       public override void fun()
       {
           Console.WriteLine();
       }
    }
}
