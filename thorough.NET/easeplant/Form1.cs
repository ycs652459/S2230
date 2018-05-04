using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easeplant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numLift = Convert.ToInt32(textBox1.Text);
            int numRight = Convert.ToInt32(textBox2.Text);
            //获取运算符
            string oper = comboBox1.Text;
            zong cal = CalculatorFactory.getInstance(oper);
            cal.NumLift = numLift;
            cal.NumRight = numRight;
            try
            {
                int rsult = cal.Calc();
                txtresulTT.Text = rsult.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                txtresulTT.Text = "";
            }
        }
    }
}
