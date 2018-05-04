using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIJAN
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.cmbList.SelectedIndex = 0;
            this.cmbexamine.SelectedIndex = 0;
        }
        //套餐泛型集合
        List<HealthCheckSet> set = new List<HealthCheckSet>();
        //检查项目
        Dictionary<string,HealthCheckItem> dic = new Dictionary<string,HealthCheckItem>();    
        //检查项目的下拉框
        public void Addexamine()
        {
            HealthCheckItem item1 = new HealthCheckItem("用于检查身高。", "身高", 5);
            HealthCheckItem item2 = new HealthCheckItem("用于检查体重。", "体重", 5);
            HealthCheckItem item3 = new HealthCheckItem("用于检查肝功能。", "肝功能", 50);
            HealthCheckItem item4 = new HealthCheckItem("用于检查视力。", "视力", 5);
            HealthCheckItem item5 = new HealthCheckItem("用于检查听力。", "听力", 5);
            HealthCheckItem item6 = new HealthCheckItem("用于检查B超。", "B超", 80);
            HealthCheckItem item7 = new HealthCheckItem("用于检查心电图。", "心电图", 100);
            dic.Add(item1.Name,item1);
            dic.Add(item2.Name, item2);
            dic.Add(item3.Name, item3);
            dic.Add(item4.Name, item4);
            dic.Add(item5.Name, item5);
            dic.Add(item6.Name, item6);
            dic.Add(item7.Name, item7);
         
            BindingSource bs = new BindingSource();
            bs.DataSource = dic.Keys;
            this.cmbexamine.DataSource = bs;
            this.cmbexamine.DisplayMember = "Name";
        }
        //新建套餐的按钮
        private void btnnew_Click(object sender, EventArgs e)
        {
            if (txtnew.Text == "" || txtnew.Text ==null )
            {
                MessageBox.Show("Sorry, it can't be empty here！！");
                return;
            }
            //创建文本框所选的值
            HealthCheckSet set2 = new HealthCheckSet(this.txtnew.Text.Trim());
            set.Add(set2);
            AddShow();
            this.cmbList.Text= this.txtnew.Text;
            this.lblName.Text = this.txtnew.Text;
            DialogResult = MessageBox.Show("添加成功！","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult != DialogResult.Yes)
            {
             
            }
          
        }
        //主窗口
        private void FrmMain_Load(object sender, EventArgs e)
        {
            
            //删除多余的列
            this.divList.AutoGenerateColumns = false;
            //删除多余的行
            this.divList.AllowUserToAddRows = false;

            HealthCheckSet set1 = new HealthCheckSet();
            set1.Name = "入学体检";
            set.Add(set1);
            //调用      
          
            AddShow();
            Addexamine();
          
        }
        /// <summary>
        /// 绑定刷新套餐下拉框
        /// </summary>
        public void AddShow()
        {
          
            this.cmbList.DataSource = new BindingList<HealthCheckSet>(set);
            //绑定自定义值
            this.cmbList.DisplayMember = "name";    
               
        }
        //套餐名称下拉框
        private void cmbList_SelectedIndexChanged(object sender, EventArgs e)
        {     //调用绑定刷新datagridview方法
            AddDgv();
            //调用刷新金额的方法
            CalcPrice();               
            //就是0下标还原初始状态（按钮为禁用，项目下拉框无项目）反之，按钮解除禁用状态，项目下拉框从新填充数据           
            if (this.cmbList.SelectedIndex >= 0)
            {
               
                this.btnAdd.Enabled = true;
                this.btndelete.Enabled = false;
            }
            else
            {
                this.btnAdd.Enabled = false;                           
            }
             

        }
        //检查体检的按钮
        private void cmbexamine_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }
        //添加给divList的添加按钮
     
        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            item();

            if (this.divList.SelectedRows.Count > 0)
            {
                this.btndelete.Enabled = true;
            }
            else
            {
                this.btndelete.Enabled = false;
            }
        }
        //绑定divList
        public void AddDgv()
        {
          
            //循环套餐类中的
            foreach (HealthCheckSet item in set)
            {
              
                if (item.Name.Equals(cmbList.Text))
                {
                      //刷新
                    this.lblName.Text = item.Name;
                    this.lblPrice.Text = item.Price.ToString();
                    this.divList.DataSource = new BindingList<HealthCheckItem>(item.Items);                              
                    return;
                }
            }
        }
        //具体绑定
        public void item()
        {
            //第一层循环，循环的是套餐的内容
            foreach (HealthCheckSet item in set)
            {
                //判断条件：如果套餐类里的名称是套餐列表的下拉框里的名称
                if (item.Name.Equals(cmbList.Text))
                {
                    //二个循环,循环的是检查项目的内容，
                    foreach (HealthCheckItem it in item.Items)
                    {
                        //体检项目的名称
                        if (it.Name.Equals(this.cmbexamine.Text))
                        {
                            /*
                             * 判定是否已存在要添加的项
                             * */
                            MessageBox.Show("您已添加过此项！");
                            return;
                        }
                    }
                    foreach (HealthCheckItem it in dic.Values)
                    {
                        if (it.Name.Equals(this.cmbexamine.Text))
                        {
                            /*
                             * 如果通过验证，可以添加，则将该项添加到集合中，并刷新datagridview与套餐价格
                             * */
                            item.Items.Add(it);
                            AddDgv();
                            CalcPrice();
                            MessageBox.Show("添加成功！");
                            return;
                        }
                    }
                    return;
                }
            }

        }
        //价格    
        public void CalcPrice()
        {
            foreach (HealthCheckSet item in set)
            {
                if (item.Name.Equals(cmbList.Text))
                {
                    /*
                     * 计算套餐金额
                     * */
                    item.Price = 0;
                    foreach (HealthCheckItem it in item.Items)
                    {
                        item.Price += it.Price;
                    }
                    //将套餐金额赋值给控件，并显示
                    this.lblPrice.Text = item.Price.ToString();
                    return;
                }
            }

        }
        //删除
        public void delete()
        {
            DialogResult = MessageBox.Show("是否确定删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                //拿到选中的员工号进行删除
                string name = this.divList.SelectedRows[0].Cells[0].Value.ToString();
                foreach (HealthCheckSet item in set)
                {                  
                    for (int i = 0; i < item.Items.Count; i++)
                    {
                        if (item.Items[i].Name.Equals(name))
                        {
                            //执行删除操作
                            item.Items.RemoveAt(i);
                            //刷新DataGridView
                            AddDgv();
                            //调用刷新金额的方法
                            CalcPrice();  
                        }
                    }
                  
                }
             
                MessageBox.Show("删除成功！");

            }
        }
        //删除的按钮
        private void btndelete_Click(object sender, EventArgs e)
        {
            delete();
            //判断删除按钮，如果DataGritw中的有大于一行的删除按钮就可以操作，否则反之！
            if (this.divList.SelectedRows.Count > 0)
            {
                this.btndelete.Enabled = true;
            }
            else
            {
                this.btndelete.Enabled = false;
            }
        }
    }
}
