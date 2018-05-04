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
    public partial class FrmRegist : Form
    {
        public FrmRegist()
        {
            InitializeComponent();
        }
        //公共变量用来接收注册按钮
        public FrmLogin fl;
        private void button1_Click(object sender, EventArgs e)
        {
            LoginInfo info = new LoginInfo();
            if (txtName.Text.Trim() == "" || txtnumber .Text.Trim() == ""|| txtpwd.Text.Trim() == ""|| txtEmail.Text.Trim() == ""||txtaffirm.Text.Trim() == ""|| txtaffirm1.Text.Trim() =="")
            {
                 MessageBox.Show("任何一处都不能为空！","提示");
            }
            else if (txtEmail.Text.Trim() != txtaffirm.Text.Trim() || txtpwd.Text.Trim() != txtaffirm1.Text.Trim())
            {
                 MessageBox.Show("密码和邮箱确认输入必须一致！","提示");
            }
            else
            {
                MessageBox.Show("恭喜，通过验证！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                for (int i = 0; i < fl.array.Length; i++)
                {
                    if (fl.array[i] == null)
                    {
                        info.Name = txtName.Text.Trim();
                        info.Password = txtpwd.Text;
                        info.Id = txtnumber.Text;
                        info.Email = txtEmail.Text;
                        fl.array[i] = info;
                        break;
                    }
                }
                fl.Visible = true;
                this.Close();
            }
           
        }

        private void FrmRegist_Load(object sender, EventArgs e)
        {

        }
    }
}
