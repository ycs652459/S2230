using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_01000
{
    //厨师类
    class Chef
    {
        private Order order;
        public void GetOrder(Order order)
        {
            this.order = order;
        }
        public void Cook()
        {
            Console.WriteLine("厨师烹制{0}", order.mealList);
            Console.WriteLine("制作完毕");
        }
        public void SendAlert(Waitress waitress)
        {
            Console.WriteLine("厨师提示服务员取餐");
            waitress.GetOrder(order);
        }

    }
}
