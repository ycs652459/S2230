using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_007003
{
    public enum Gender
    { 
        男,女
    }
   public class SE
    {
        public string ID { get; set; }//号
        public int Age { get; set; }//年龄       
        public string Name { get; set; }//姓名
        public Gender Gender { get; set; }//性别
        protected int count { get; set; }
        public SE() { }
        //有参构造
        public SE(string id, int age, string name, Gender gender, int count) 
        {
            this.ID = id;
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
            this.count = count;
        }
       //用虚方法实现多态的基本步骤如下
       //2.把父类类型作为形象参数，他的子类对象作为实参传入
        public void Play(Instrument instrument)
        {
            instrument.Play();
        }
    }
}
