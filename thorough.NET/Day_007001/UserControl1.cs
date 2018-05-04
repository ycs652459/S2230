using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_007001
{
    public partial class txtContro1 : TextBox
    {
        public txtContro1()
        {
            InitializeComponent();
        }

        private void txtContro1_KeyPress(object sender, KeyPressEventArgs e)
        {

            txtContro1 re = new txtContro1();



            //if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;//消除不合适字符
            //}
            //else if (Char.IsPunctuation(e.KeyChar))
            //{
            //    if (e.KeyChar != '.' || re.Text.Length == 0)//小数点
            //    {
            //        e.Handled = true;
            //    }
            //    if (re.Text.LastIndexOf('.') != -1)
            //    {
            //        e.Handled = true;
            //    }
            //}      
            //if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            //{
            //    e.Handled = true;        
            //}
            //int a = 0; //计算小数点的个数的变量  
            //a = re.Text.ToString().Trim().Split('.').Length;
            //if (e.KeyChar == (char)46 && a == 0)
            //{
            //    e.Handled = true;
            //    MessageBox.Show("注意只能输入一个小数点", "友情提示");
            //    return;
            //}  



            //try
            //{
            //    txtContro1 re = new txtContro1();
            //    int bum = int.Parse(re.Text);
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("只能输入数字"+ex.Message);
            //}

            //只能输入退格键、回车键、小数点和数字  
            if (e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)46 && !(char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("请输入数字和小数点", "友情提示");
                re.Focus();
                return;
            }

            int a = 0; //计算小数点的个数的变量  
            a = re.Text.ToString().Trim().Split('.').Length;

            if (e.KeyChar == (char)46 && a > 1)
            {
                e.Handled = true;
                MessageBox.Show("注意只能输入一个小数点", "友情提示");
                return;
            }

            if (e.KeyChar == (char)46 && re.Text.Length == 0)
            {
                e.Handled = true;
                MessageBox.Show("请先输入数字", "友情提示");
                return;
            }        
        }
    }
}
