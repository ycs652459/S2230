using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSpy
{
    //节目类
   public class TVProgram
    {
       //播放时间
        public DateTime Playtime { get; set; }
       //早，中，晚间档
        public string ShiDuan { get; set; }
       //节目的名称
        public string Name { get; set; }
       //视频的地址
        public string Path { get; set; }
   }
}
