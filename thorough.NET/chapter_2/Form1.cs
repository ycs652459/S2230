using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter_2
{
    public partial class Form1 : Form
    {

        List<Employee> empls = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Init()
        {
            List<job> list = new List<job>();
            list.Add(new job("彪马","购物车模块"));
            list.Add(new job("测试","给购物车模块做单元测试"));
            SE ai = new SE("112","sdc",25,Gender.男,100,list);

            List<job> list1 = new List<job>();
            list.Add(new job("士大夫", "购物车模块"));
            list.Add(new job("说的", "给购物车模块做单元测试"));
            SE at = new SE("112", "sdf", 25, Gender.女, 100, list);

            PE pe = new PE("55","asd",50,Gender.男,30,null);
            empls.Add(ai);
            empls.Add(at);
            empls.Add(pe);
        }
        private void btnReport_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < empls.Count; i++)
            {
                if (empls[i] is SE)
                {
                    SE se = empls[i] as SE;
                    Console.WriteLine(se.DoWork());
                }
                if (empls[i] is PE)
                {
                    PE se = empls[i] as PE;
                    Console.WriteLine(se.DoWork());
                }
                
            }
            //foreach (Employee item in empls)
            //{
            //    //if (item is PE)
            //    //{
            //    //    MessageBox.Show(((PE)item).DoWork(),"汇报");
            //    //}
            //    //if (item is SE)
            //    //{
            //    //    MessageBox.Show(((SE)item).DoWork(),"汇报");
            //    //}\
            //    Console.WriteLine(item.);
            //}
        }
    }
}
