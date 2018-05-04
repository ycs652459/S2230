using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_ticket
{
    //赠送子类

    class FreeTicket:Ticket
    {
        //获得增票者的名字的属性
        private string customername;


        public FreeTicket() { }
        public FreeTicket(ScheduleItem scheduleItem, Seat seat, string customerName)
            : base(scheduleItem, seat)
        {
            this.Customername = customerName;
        }

        //重写父类计算票价
        public override void CalcPrice()
        {
            this.Price = 0;
        }
        //重写父类打印售票信息
        public override void Print()
        {
            base.Print();
        }
        //重写父类显示当前售票信息
        public override void Show()
        {
            base.Show();
        }
        public string Customername
        {
            get { return customername; }
            set { customername = value; }
        }

        
    }
}
