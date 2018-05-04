using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Child
{
    class Employee
    {
        protected int age;
        protected void Play()
        {
            int hours;
        }
        public virtual string SayHillo()
        {
            string message = string.Format("大家好！");
            return message;
        }
    }
}
