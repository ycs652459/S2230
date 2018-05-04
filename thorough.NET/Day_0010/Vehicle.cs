using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_0010
{
    //抽象类
   public abstract class Vehicle
    {
        public string Color { get; set; }//颜色
        public double DailyRent { get; set; }//每日租金
        public string LicenseNO { get; set; }//车牌号
        public string Name { get; set; }//名字
        public int RentDate { get; set; }//还日期
        public string RentUser { get; set; }//租用者
        public int YearOfService { get; set; }//使用时间
        public Vehicle() { }
        public Vehicle(string Color, double DailyRent, string LicenseNO, string Name,int YearOfService) 
          {
              this.Color = Color;
              this.DailyRent = DailyRent;
              this.LicenseNO = LicenseNO; ;
              this.Name = Name;           
              this.YearOfService = YearOfService;      
        }
        //计算价格的方法
        public abstract double CalculatePrice();
    }
}
