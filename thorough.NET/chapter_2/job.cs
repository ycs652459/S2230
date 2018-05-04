using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_2
{
    //job类，定义工作项目
   public class job
    {
        
        public string Name { get; set; }
        //描述
        public string Description { get; set; }
        public job() { }
        public job(string name,string description) 
        {
            this.Name = name;

            this.Description = description;
        }
    }
}
