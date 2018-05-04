using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_01000
{
    class Program
    {
        static void Main(string[] args)
        {
            Client wang = new Client();
            Waitress waitress = new Waitress();
            Waitress zhang = new Waitress();
            Chef chef = new Chef();
            Order order = new Order();
            order.customer = wang;
            order.id = 100;
            order.mealList = "水煮鱼";

            wang.Order(waitress, order);
            waitress.SendOrder(chef);
            chef.Cook();
            chef.SendAlert(waitress);
            waitress.TransCook();
            Console.ReadLine();

        }
      
    }
}
