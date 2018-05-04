using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_test
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //调用对象
        Grade gr = new Grade();
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //调用添加学生
            gr.AddStudent();

            int i = 0;
            foreach (var item in Grade.list)
	{
                i++;
                Button btn = new Button();
                //控件名称
                btn.Name = "mybutton" + i.ToString();
                //控件显示文本             
                btn.Text = string.Format("{0}", item.StuName);
                //控件大小
                btn.Size = new Size(50, 50);
                //控件位置【动态变化】
                btn.Location = new Point(50 + i % 5 * 100, 50 +100);
                //添加到窗体
                this.Controls.Add(btn);
            }                    
        }
    }
}
