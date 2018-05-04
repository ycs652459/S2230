using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema_ticket
{

    //自定义MovieType枚举类型
    public enum MovieType
{
    Action, Comedy
}
    //电影类
    [Serializable]
   public class Movie
    {
      //电影名
        private string movieName;
       //海报图片名
        private string poster;

       //导演名
        private string director;
       //主演
        private string actor;
       //定价
        private int price;

       //枚举类型
        private MovieType movieType;


       // public Movie() { }
       ////
       // public Movie()         
       // { 
        
       // }

        public MovieType MovieType
        {
            get { return movieType; }
            set { movieType = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Actor
        {
            get { return actor; }
            set { actor = value; }
        }

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        public string Poster
        {
            get { return poster; }
            set { poster = value; }
        }

        public string MovieName
        {
            get { return movieName; }
            set { movieName = value; }
        }
    }
}
