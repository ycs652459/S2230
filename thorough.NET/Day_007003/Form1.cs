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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "Calmness.ssk";
            Init();
            
        }
        //初始化
        public void Init()
        { 
              List<SE> list = new List<SE>();
              SE jack = new SE("001", 22, "谢爱明", Gender.女, 100);
              SE joe = new SE("002", 32, "夏明", Gender.女, 100);
              SE ema = new SE("003", 25, "安顺场", Gender.男, 100);
              list.Add(jack);
              list.Add(joe);
              list.Add(ema);
            //绑定Date
              this.dataGridView1.DataSource = list;
        }
    
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void 演奏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayFrom fm = new PlayFrom();
            DataGridViewRow dr = this.dataGridView1.CurrentRow;
            if (dr == null)
            {
                return;
            }
            string seName = dr.Cells[1].Value.ToString();
            fm.Tile = seName + "开始演奏";
            fm.ShowDialog();
        }
    }
}
