using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_007003
{
    public partial class PlayFrom : Form
    {
        public PlayFrom()
        {
            InitializeComponent();
        }
        //设置标题
        public string Tile
        {
            set
            {
                this.groupBox1.Text = value;
            }
        }
        private void PlayFrom_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SE se = new SE();
            Instrument instrument = null;
            //设置选中的乐器
            if (this.radioButton1.Checked)
            {
                instrument = new Sachs();
            }
            else if (this.radioButton2.Checked)
            {
                instrument = new Violin();
            }
            else if (this.radioButton3.Checked)
            {
                instrument = new Piano();
            }
            se.Play(instrument);
        }
    }
}
