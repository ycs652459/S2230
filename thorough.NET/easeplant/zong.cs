using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easeplant
{
   public abstract class zong
    {
        private int numLift;
        private int numRight;
        public abstract int Calc();
        public int NumRight
        {
            get { return numRight; }
            set { numRight = value; }
        }
        public int NumLift
        {
            get { return numLift; }
            set { numLift = value; }
        } 
    }
}
