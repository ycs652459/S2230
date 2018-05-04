using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thorought.NET.xiangm
{
    public partial class FrmJudge : Form
    {


        //第二种方法
        public ListViewItem item = null;//获取整行的信息



        ////保存父窗体的示例
        //private FrmShow myParent;
        ////要评价的员工对象
        //private SE se;
        //public FrmJudge(FrmShow fparent, int index)
        //{
        //    InitializeComponent();
        //    this.myParent = fparent;
        //    this.se = myParent.en[index];

        //}
        public FrmJudge()
        {
            InitializeComponent();
         
        }
        //主窗口
        private void FrmJudge_Load(object sender, EventArgs e)
        {
            //this.txtName.Text = se.Name;//姓名
            //this.txtgrade.Text = se.Grade;//文字评分
            //this.txtevaluate.Text = se.Manager.ToString();//数字评分


            this.txtName.Text = item.SubItems[1].Text;//绑定名字文本ku
            txtName.ReadOnly = true;//只读


        }
        //评分按钮
        private void btngrade_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    PM pm = new PM();
            //    pm.Judge(se,this.txtgrade.Text.Trim(),Int32.Parse(this.txtevaluate.Text.Trim()));
            //    this.myParent.UpdateView();//刷新窗口
            //    this.Close();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}

            item.SubItems[3].Text = this.txtgrade.Text.Trim();
            item.SubItems[4].Text = this.txtevaluate.Text.Trim();
            this.Close();



        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
