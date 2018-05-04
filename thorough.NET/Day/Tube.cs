
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day
{
    //地铁类   
   public class Tube:TrafficTool
    {
       public override void Run()
       {
           Console.WriteLine("地铁在于逆行");
       }
    }
}
