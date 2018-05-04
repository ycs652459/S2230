using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thorough.NET
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //定义一个公共的变量
        public string txtname;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //从FrmLOGIN中拿到输入的值来赋给文本框里的内容
            textBox1.Text =txtname;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
