using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_0010
{
   public class VehicleUtil
    {
        //第一一个静态方法,返回值类型是父类类型,传入参数
       public static Vehicle CreateVehicle(string Color, double DailyRent, string LicenseNO, string Name,int YearOfService, int load, string type)
        {
            //给对象赋null值
            Vehicle vehicle = null;
            switch (type)
            {
                case "轿车":
                 //   vehicle = new Car(Color, DailyRent, LicenseNO, Name, YearOfService);
                    break;
                case "卡车":
                    vehicle = new Truck(Color, DailyRent, LicenseNO, Name,YearOfService, load);
                    break;

            }
            return vehicle;

        }
    }
}
