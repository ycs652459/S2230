﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_007001
{
    public partial class Form1 : Gdu.WinFormUI.GMForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //foreach (Control item in this.Controls)
            //{
            //    //if (item is TextBox)
            //    //{
                    
            //    //}
            //    //TextBox txtbox = item as TextBox;
            //   // txtbox.Text = "";
            //}
        }

        private void txtContro11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContro11_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能输入退格键、回车键、小数点和数字  
            //if (e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)46 && !(char.IsNumber(e.KeyChar)))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("请输入数字和小数点", "友情提示");
            //    txtContro11.Focus();
            //    return;
            //}

           
            //if (e.KeyChar == (char)46 && txtContro11.Text.Length == 0)
            //{
            //    e.Handled = true;
            //    MessageBox.Show("请先输入数字", "友情提示");
            //    return;
            //}
            //int a = 0; //计算小数点的个数的变量  
            //a = txtContro11.Text.ToString().Trim().Split('.').Length;

            //if (e.KeyChar == (char)46 && a > 1)
            //{
            //    e.Handled = true;
            //    MessageBox.Show("注意只能输入一个小数点", "友情提示");
            //    return;
            //}

        }
    }
}
