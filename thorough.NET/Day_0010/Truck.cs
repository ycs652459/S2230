using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_0010
{
    //卡车类
   public class Truck:Vehicle
    {
        private int load;//装载量      
        public Truck(){ }
        public Truck(string Color, double DailyRent, string LicenseNO, string Name,int YearOfService,int load)
            : base(Color, DailyRent, LicenseNO, Name,YearOfService) 
        {
            this.Load = load;
        }
        public int Load
        {
            get { return load; }
            set { load = value; }
        }
       //卡车类的计算方法
        public override double CalculatePrice()
        {
            double money = this.DailyRent * RentDate;
            return money;
        }
       
    }
}
