﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easeplant
{
   public class Add:zong
    {
       public override int Calc()
       {
           return this.NumLift + this.NumRight;
       }
    }
}
