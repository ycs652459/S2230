using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_test
{
    class Grade
    {
     public static List<Student> list = new List<Student>();
        //能以形参指定的位置为起点，一字排开显示所有的学生对象。
//书写一个AddStudent（）用于添加学生
     public List<string> DisplayStudent(Point point)
     {
         int count = 0;
         List<string> newlist = new List<string>();
         foreach (Student item in list)
         {
             count++;
             newlist.Add(item.StuName+":"+(point.X+80*count)+":"+(point.Y+50));
         }
         return newlist;
     }

     public void AddStudent(Student stu)
     {
         list.Add(stu);
     }
        
        
        public void AddStudent()
        {
            Student stu = new Student();
            stu.StuName = "甄子丹";
            Student stu1 = new Student();
            stu1.StuName = "成龙";
            Student stu2 = new Student();
            stu2.StuName = "李小龙";
            Student stu3 = new Student();
            stu3.StuName = "李连杰";
            list.Add(stu);
            list.Add(stu1);
            list.Add(stu2);
            list.Add(stu3);
           
       }

       
      
    }
}
