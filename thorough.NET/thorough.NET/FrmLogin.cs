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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public LoginInfo[] array;
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegist fm = new FrmRegist();
            fm.fl = this;
            fm.Show();
            this.Hide();
        }
       
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //初始化用户信息
            array = new LoginInfo[10];
            LoginInfo sb = new LoginInfo();
            sb.Name = "1";
            sb.Id = "1234567890";
            sb.Email = "123@qq.com";
            sb.Password = "1";
            //赋值给数组
            array[0] = sb;
            //lblValidation.Visible = false;


        }
        //登录 按钮
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == ""|| txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("用户名或密码不能为空！","提示");
            }
            else
            {
                string userName = txtEmail.Text;
                string pwd = txtPwd.Text;
                bool isOK = false;
                foreach (LoginInfo item in array)
                {
                    if (item != null)
                    {
                        if (item.Email == userName && item.Password == pwd)
                        {
                            isOK = true;
                            FrmMain fm = new FrmMain();
                            fm.txtname = "欢迎，" + item.Name;
                            fm.Show();
                            break;
                        }

                    }
                }
                if (isOK == false)
                {
                    txtPwd.Text = "";
                    txtPwd.Focus();

                }
            }
        }
    }
}
