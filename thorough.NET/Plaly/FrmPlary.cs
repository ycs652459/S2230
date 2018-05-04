using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plaly
{
    public partial class FrmPlary : Form
    {

        private FrmPlary()
        {
            InitializeComponent();
        }
        public string Path;
        private static FrmPlary onlyone;
        public static FrmPlary getInstance()
        {
            if (onlyone == null)
            {
                onlyone = new FrmPlary();
            }
            return onlyone;
        }
        private void FrmPlary_Load(object sender, EventArgs e)
        {           
        }
        public void PlaySong()
        {
            if ( this.Player1.URL == Path)
            {
                
            }
            this.Player1.URL = Path;
        }
    }
}
