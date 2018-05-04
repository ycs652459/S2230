using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_0010
{
    //汽车类
    public class Car : Vehicle
    {
        public Car() { }
        public Car(string Color, double DailyRent, string LicenseNO, string Name,int YearOfService)
            : base(Color, DailyRent, LicenseNO, Name, YearOfService)
        {

        }
        //汽车的计算方法
        public override double CalculatePrice()
        {
            //定义变量保存价格
            double SumPrice = this.DailyRent * RentDate;
            return SumPrice;
        }
    }
}
