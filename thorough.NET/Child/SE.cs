using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Child
{
    class SE:Employee
    {
        private string hobby;
        public void Study()
        {
           
            }
        public override string SayHillo()
        {
            string message = string.Format("很好");
            return message;
        }

    }
}
