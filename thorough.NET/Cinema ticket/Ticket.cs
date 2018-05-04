using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_ticket
{
    //电影票的父类，保存电影票信息
    [Serializable]
   public class Ticket
    {
       public Ticket() { }
       public Ticket(ScheduleItem scheduleItem, Seat seat)
       {
           this.ScheduleItem = scheduleItem;
           this.Seat = seat;
       }



        //放映场次
        private ScheduleItem scheduleItem;

        internal ScheduleItem ScheduleItem
        {
            get { return scheduleItem; }
            set { scheduleItem = value; }
        }
        //所属座位对象Seat
        private Seat seat;
        public Seat Seat
        {
            get { return seat; }
            set { seat = value; }
        }
        //票价
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        //计算票价的虚方法
        public virtual void CalcPrice()
        {
            this.Price = this.ScheduleItem.Movie.Price;
        }
        //打印售票信息的虚方法
        public virtual void Print()
        {
            string fileName = this.ScheduleItem.Time.Replace(":","-")+""+this.Seat.SeatNum+".txt";
            FileStream fs = new FileStream(fileName,FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("*************************");
            sw.WriteLine("        青鸟影院");
            sw.WriteLine("-------------------------");
            sw.WriteLine("电影名:\t{0}",this.ScheduleItem.Movie.MovieName);
            sw.WriteLine("时间：\t{0}",this.ScheduleItem.Time);
            sw.WriteLine("座位号：\t{0}",this.Seat.SeatNum);
            sw.WriteLine("价格：\t{0}",this.Price.ToString());
            sw.Close();
            fs.Close();
            }
        //显示当前的出售信息
        public virtual void Show()
        {
            MessageBox.Show("已经售出");
        }

    }
}
