using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day
{
   public class Employee
    {
        public string Name { get; set; }

       public void Gohome(TrafficTool tool)
       {
           Console.WriteLine("员工："+this.Name);
           tool.Run();
       }
    }
}
