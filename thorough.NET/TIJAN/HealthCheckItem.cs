using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIJAN
{
    /// <summary>
    /// 项目类
    /// </summary>
    class HealthCheckItem
    {
        //项目描述
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        //项目名称
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //项目价格
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        //无参构造
        public HealthCheckItem()
        { 
        
            }
        //有参构造
        public HealthCheckItem(string description,string name,int price)
        {
            this.Description = description;
            this.Name = name;
            this.Price = price;
        }
    }
}
