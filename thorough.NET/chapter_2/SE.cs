using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_2
{
  public class SE:Employee
    {
        private int popularity;

        public override string DoWork()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name +":\n");
            for (int i = 0; i < this.WorkList.Count; i++)
            {
                sb.Append((i+1)+","+WorkList[i].Name+":"+WorkList[i].Description+"\n");
            }
            return sb.ToString();
        }
      public SE() { }
      //有参构造
       public SE(string id, string name, int age, Gender gender, int popularity,List<job> List)
           :base(id,age,name,gender,List)        
        {
            this.popularity = popularity;
        
        }
        public int Popularity
        {
            get { return popularity; }
            set { popularity = value; }
        }
    }
}
