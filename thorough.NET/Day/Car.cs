using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day
{
    //小汽车
  public class Car:TrafficTool
    {
      public override void Run()
      {
          Console.WriteLine("小汽车在于逆行");
      }
    }
}
