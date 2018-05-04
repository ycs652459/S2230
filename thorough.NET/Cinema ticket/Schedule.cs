using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
namespace Cinema_ticket
{

    [Serializable]
    //放映计划类
   public class Schedule
    {
       //放映场次属性
        private Dictionary<string, ScheduleItem> items = new Dictionary<string, ScheduleItem>();

        public Dictionary<string, ScheduleItem> Items
        {
            get { return items; }
            set { items = value; }
        }
        
       //解析xml文件
        public void LoadItems()
        {
            items.Clear();
            XmlDocument xd = new XmlDocument();
            xd.Load("ShowList (1).xml");
            XmlElement xe = xd.DocumentElement;
            foreach (XmlNode item in xe.ChildNodes)
            {
                Movie mv = new Movie();
                mv.MovieName = item["Name"].InnerText;
                mv.Poster = item["Poster"].InnerText;
                mv.Director = item["Director"].InnerText;
                mv.Actor = item["Actor"].InnerText;
                //电影类型没有枚举类型都是字符串所以的转成枚举类型
                mv.MovieType = (MovieType)Enum.Parse(typeof(MovieType), item["Type"].InnerText);
                mv.Price = Convert.ToInt32(item["Price"].InnerText);

                foreach (XmlNode item1 in item["Schedule"].ChildNodes)
                {
                    ScheduleItem si = new ScheduleItem();
                    si.Time = item1.InnerText;
                    si.Movie = mv;
                    items.Add(si.Time,si);
                }

            }
        }
    }
}
