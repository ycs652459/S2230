using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_2
{
  public class PE:Employee
    {
        private int yearOfExperience;
        public override string DoWork()
        {
            string message = this.Name+":管理员工完成工作内容！";
            return message;
        }
        public PE(string id, string name, int age, Gender gender, int yearOfExperience, List<job> List)
            : base(id, age, name, gender, List)        
        {
            this.YearOfExperience = yearOfExperience;
        
        }

public int YearOfExperience
{
  get { return yearOfExperience; }
  set { yearOfExperience = value; }
}}
}
