using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Child
{
   public enum Genner{      
   男,女
   }
   public class Parent
    {
        private int age;
        private string name;
        //构造
        public Parent() { }
        //有参构造
        public Parent(string name,int age,Genner gender) {
            this.age = age;
            this.name = name;
            this.gender = gender;      
        }
       //定义枚举
        public Genner gender { get; set; }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
      

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
