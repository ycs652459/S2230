using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easeplant
{
   public class CalculatorFactory
    {
       public static zong getInstance(string oper)
       {
           zong cal = null;
           switch (oper)
           {
               case "+":
                   cal = new Add();
                   break;
               case "-":
                   cal = new Add();
                   break;
               case "*":
                   cal = new Add();
                   break;
               case "/":
                   cal = new Add();
                   break;
               default:
                   break;
           }
           return cal;
        }
    }
}
