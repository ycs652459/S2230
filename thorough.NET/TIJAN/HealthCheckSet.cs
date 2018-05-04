using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIJAN
{
    /// <summary>
    /// 套餐类
    /// </summary>
    class HealthCheckSet
    {
        //套餐名称
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //套餐价格
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        List<HealthCheckItem> items = new List<HealthCheckItem>();

        internal List<HealthCheckItem> Items
        {
            get { return items; }
            set { items = value; }
        }
        //无参构造
        public HealthCheckSet()
        { 
            
        }
       
        //有参构造
        public HealthCheckSet(string name)
        {
            this.Name = name;

        }
    }

}
