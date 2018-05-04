using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day
{
    /// <summary>
    /// 自行车
    /// </summary>
   public class Bicycle:TrafficTool
    {
       public override void Run()
       {
           Console.WriteLine("自行车在于逆行");
       }
    }
}
