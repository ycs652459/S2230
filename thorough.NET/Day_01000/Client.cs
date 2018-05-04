using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_01000
{

    //顾客类
    class Client
    {
        public void Order(Waitress waitress, Order order)
        {
            Console.WriteLine("顾客点餐{0}!", order.mealList);
            waitress.GetOrder(order);
        }
        public void Eat()
        {
            Console.WriteLine("客人用餐");
        }

    }
}
