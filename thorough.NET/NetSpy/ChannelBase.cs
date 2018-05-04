using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSpy
{
   public abstract class ChannelBase
    {
        public string ChanName { get; set; }
       //地址
        public string Path { get; set; }
       //节目列表，该屏道上的所有列表
        public List<TVProgram> ProgramList { get; set; }
        public int MyProperty { get; set; }
       //获取列表
        public abstract void Fetch();
    }
}
