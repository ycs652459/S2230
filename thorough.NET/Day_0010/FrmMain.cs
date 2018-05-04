using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_0010
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "Silver.ssk";
            
        }
        //初始化可租用车集合信息
        Dictionary<string, Vehicle> dic = new Dictionary<string, Vehicle>();
        //初始化结算车的集合信息
        Dictionary<string, Vehicle> rentVehicles = new Dictionary<string, Vehicle>();
        //刷新的按钮
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Info(dic,listView1);
        }
        //初始值出租
        public void Info(Dictionary<string, Vehicle> dic, ListView lv)
        {                      
            //循环之前先清空
            lv.Items.Clear();  
            //循环绑定         
            foreach (Vehicle item in dic.Values)
            {              
                ListViewItem lv1 = new ListViewItem();
                lv1.Text = item.LicenseNO;
                lv1.SubItems.Add(item.Name);
                lv1.SubItems.Add(item.Color);
                lv1.SubItems.Add(item.DailyRent.ToString());
                lv1.SubItems.Add(item.RentDate.ToString());
                //判断
                if (item is Truck)
                {
                    lv1.SubItems.Add((item as Truck).Load.ToString());
                }
                else
                {
                    lv1.SubItems.Add("无");
                    
                }
                //总的
                lv.Items.Add(lv1);

            }
        }
      //还车的循环刷新
        public void Info1(Dictionary<string, Vehicle> rentVehicles, ListView list)
        {
            list.Items.Clear();
            foreach (Vehicle item in rentVehicles.Values)
            {
                ListViewItem lv1 = new ListViewItem();
                lv1.Text = item.LicenseNO;
                lv1.SubItems.Add(item.Name);
                lv1.SubItems.Add(item.Color);
                lv1.SubItems.Add(item.DailyRent.ToString());
                lv1.SubItems.Add(item.RentDate.ToString());
                //判断
                if (item is Truck)
                {
                    lv1.SubItems.Add((item as Truck).Load.ToString());
                }
                else
                {
                    lv1.SubItems.Add("无");

                }
                //总的
                list.Items.Add(lv1);
            }
        }
        // 主窗口   
        private void FrmMain_Load(object sender, EventArgs e)
        {

            Car car = new Car("黄色", 300, "鲁888888", "法拉利",3);
            Car car1 = new Car("白色", 250, "鲁88888", "奥托",4);
            Truck t1 = new Truck
            {
                LicenseNO = "湘B666666",
                Name = "东风A5",
                Color = "蓝色",
                DailyRent = 2000,
                YearOfService = 2,
                Load = 120
            };
            dic.Add(car.LicenseNO, car);
            dic.Add(car1.LicenseNO, car1);
            dic.Add(t1.LicenseNO, t1);
            //绑定控件
            Info(dic, listView1);
            //给颜色下拉框赋值
            this.comboBox1.Items.Add("红色");
            this.comboBox1.Items.Add("蓝色");
            this.comboBox1.Items.Add("白色");
            this.comboBox1.Items.Add("黑色");
            this.comboBox1.Items.Add("灰色");
            this.textBox5.Enabled = false;
        }
        //租车
        private void btnCar_Click(object sender, EventArgs e)
        {
            //判断
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行！");
            }
            else if (this.txtHirer.Text == "")
            {
                MessageBox.Show("请输入租用者的名字");
            }
            else
            {
                //这是通过选择车牌号
                string key = listView1.SelectedItems[0].Text;
                //租用者和车牌号绑定在一起
                dic[key].RentUser = this.txtHirer.Text;
                //将已租车辆放入到已租集合中
                rentVehicles.Add(dic[key].LicenseNO, dic[key]);
                //判断是否已经出租
                if (dic.ContainsKey(key))
                {
                    dic.Remove(key);
                }
                //重新绑定listView
                Info(dic, listView1);
                MessageBox.Show("已出租");
                //使用者赋空
                this.txtHirer.Text = "";
            }
            
        }
        //还车刷新
        private void btnshaxin_Click(object sender, EventArgs e)
        {
            Info1(rentVehicles,listView2);
        }
        //还车的选择结算
        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (this.listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择车辆！！");
                return;
            }
            if (this.txtDay.Text == "")
            {
                MessageBox.Show("请输入租用天数！");
                return;
            }
            string key = listView2.SelectedItems[0].Text;
            rentVehicles[key].RentDate = int.Parse(this.txtDay.Text);
            //调用抽象方法
            double totalPrice = rentVehicles[key].CalculatePrice();
            string msg = string.Format("您的总价是{0}",totalPrice.ToString());
            MessageBox.Show(msg,"提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //加入到可租车辆集合里
            dic.Add(rentVehicles[key].LicenseNO,rentVehicles[key]);
            //从当前的集合中移除
            if (rentVehicles.ContainsKey(key))
            {
                rentVehicles.Remove(key);
            }
            //重新刷新列表
            Info1(rentVehicles, listView2);
            //租用天数赋空
            this.txtDay.Text = "";
        }
        //新车入库按钮
        private void btnRuku_Click(object sender, EventArgs e)
        {
            //友情判断
            if (limousine() == true)
            {
                //遍历车牌号
                foreach (string item in dic.Keys)
                {
                    
                    if (textBox1.Text == item)
                    {
                        
                        MessageBox.Show("该车牌号已经存在");
                        return;
                    }                  

                }
                Vehicle vs = null;
                //运用里氏替换原则
                if (radioButton1.Checked == true)
                {
                  
                    vs = new Car();

                }
                else if (radioButton2.Checked == true)
                {
                    Truck tr = new Truck();
                    tr.Load = Convert.ToInt32(textBox5.Text);
                    vs = new Truck();
                    vs = tr;
                           

                }
                //01获取对应文本框中的值,
                vs.LicenseNO = textBox1.Text;//车号
                vs.Name = textBox2.Text;//车型
                vs.Color = comboBox1.Text;//颜色
                vs.YearOfService = Convert.ToInt32(textBox3.Text);//使用时间
                vs.DailyRent = Convert.ToInt32(textBox4.Text);//每日租金  
                dic.Add(vs.LicenseNO, vs);
                uptatetxt();
                MessageBox.Show("添加成功!");


           
            }
          
        }
        //卡车友情提示
        public bool truck()
        {
            if (radioButton1.Checked == false&& radioButton2.Checked == false)
            {
                MessageBox.Show("请选择车辆类型！");
                return false;
            }
            else if (textBox1.Text == ""||textBox2.Text == ""||textBox3.Text == ""||comboBox1.Text == ""||textBox4.Text == ""||textBox5.Text == "")
            {
                MessageBox.Show("请填写完整！！");
                return false;
            }
            else
            {
                return true;  
            }
        }

        //轿车的友情提示
        public bool limousine()
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("请选择车辆类型！");
                return false;
            }
            else if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("请填写完整！！");
                return false;
            }
            else
            {
                return true;
            }
        }
        //轿车
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.textBox5.Enabled = false;
            }
        }
        //卡车
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                this.textBox5.Enabled = true;
            }
        }
        //当写完文本框赋空
        public void uptatetxt()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.comboBox1.Text = "";
        }
    }
}
