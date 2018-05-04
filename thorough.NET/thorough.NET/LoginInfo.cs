using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace thorough.NET
{
  public  class LoginInfo
    {

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
    }
}
