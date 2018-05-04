using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_1
{
   public abstract class Vehicle
    {
       public Vehicle()
       {
           Console.WriteLine("A");
   }
       public virtual void Fun()
       {
           Console.WriteLine("A.fun()");
       }
        ////型号
        
        //public string Type { set; get; }
        ////产地
        //public string Place { set; get; }
        ////无参构造
        //public Vehicle() { }

     
        ////有参构造
        //public Vehicle(string type,string place)
        //{
        //    this.Type = type;
        //    this.Place = place;
        //}
        //public void VeicleRun()
        //{
        //    Console.WriteLine("汽车在行驶！");
        //}
    }
}
