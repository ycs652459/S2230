﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 序列化与反序列化
{
    [Serializable]
   public class Person
    {
        public string  Name { get; set; }
        public int Age { get; set; }
    }
}
