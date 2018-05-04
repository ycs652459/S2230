
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_007003
{
   public class Piano:Instrument
    {
       public virtual void Play()
       {
           MessageBox.Show("钢琴在演奏", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
       }
    }
}
