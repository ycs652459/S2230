using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Child
{
    class Childer:Parent
    {

        private string HomeAdderss;
      //无参构造
        public Childer() { }
        //有参构造
      

        public string HomeAdderss1
        {
            get { return HomeAdderss; }
            set { HomeAdderss = value; }
        }
       

    }
}
