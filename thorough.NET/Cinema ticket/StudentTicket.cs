using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_ticket
{
    //学生票子类
   public class StudentTicket:Ticket
    {
       //学生票的折扣
        private int discount;
       //计算父类
        public override void CalcPrice()
        {
            this.Price = this.ScheduleItem.Movie.Price * Discount / 10;
        }
      
       //打印售票信息
        public override void Print()
        {
            base.Print();
        }
        
       //显示当前售票信息
        public override void Show()
        {
            base.Show();
        }
        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        public StudentTicket() { }
       //有参构造继承父类
        public StudentTicket(ScheduleItem scheduleItem, Seat seat, int discount)
            :base(scheduleItem,seat)
        {
            this.Discount = discount;
        }
    }
}
