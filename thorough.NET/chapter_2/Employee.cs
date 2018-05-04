using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_2
{

    //枚举性别
    public enum Gender
{
    男,女
}
    //父类
   public class Employee
    {
        public string ID { get; set; }//号
        public int Age { get; set; }//年龄       
        public string Name { get; set; }//姓名
        public Gender Gender { get; set; }//性别
        protected List<job> WorkList { get; set; }
        public Employee() { }
        //有参构造
        public Employee(string id,int age,string name,Gender gender,List<job> List) 
        {
            this.ID = id;
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
            this.WorkList = List;
        }
       
    }
}
