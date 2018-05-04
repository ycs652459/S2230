using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checking_inInfo
{
    public partial class Frmclock : Form
    {
        public Frmclock()
        {
            InitializeComponent();
        }
        //保存父级
        public FrmMain FrmParent { get; set; }    

        public void show()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = FrmParent.dic.Values;
            this.dataGridView1.DataSource = bs;
        }
        private void Frmclock_Load(object sender, EventArgs e)
        {
            show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
