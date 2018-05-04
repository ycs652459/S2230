using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema_ticket
{
    //影院每天放映计划的场次，保存每场电影的信息

   public class ScheduleItem
    {
       //放映的时间
        private string time;
       //本场所放映电影的属性
        private Movie movie;

        public Movie Movie
        {
            get { return movie; }
            set { movie = value; }
        }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

    }
}
