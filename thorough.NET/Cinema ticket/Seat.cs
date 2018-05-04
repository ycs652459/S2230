using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Cinema_ticket
{
    //保存影院的座位信息
   public class Seat
    {
       //座位号
        private string seatNum;
       //座位卖出状态颜色
        private Color color;
        public Seat() { }
        public Seat(string seatNum,Color color)     
        { 
            this.SeatNum = seatNum;
            this.Color = color;
        }
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        public string SeatNum
        {
            get { return seatNum; }
            set { seatNum = value; }
        }
    }
}
