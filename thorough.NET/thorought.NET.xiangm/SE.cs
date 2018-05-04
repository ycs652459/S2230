using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thorought.NET.xiangm
{
   public class SE
    {
        //工号
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        //年龄
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        //姓名
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //性别
        private char sex;
        public char Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        //人气值
        private int Popularity;

        public int Popularity1
        {
            get { return Popularity; }
            set { Popularity = value; }
        }
        //项目经理年度评分
        private string grade;

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        //经理评分
        private int manager;

        public int Manager
        {
            get { return manager; }
            set { manager = value; }
        }

    }
}
