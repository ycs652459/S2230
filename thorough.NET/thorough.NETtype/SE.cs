using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thorough.NETtype
{
   public class SE
    {
        public string Name { get; set; }
        public int Price {get;set; }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
