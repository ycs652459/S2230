using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_ticket
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.groupBox2.Enabled = false;
        }
        //存储所有lable控件信息（方便改变控件状态）
        Dictionary<string, Label> labels = new Dictionary<string, Label>();
        //放映计划类
        Schedule sd = new Schedule();
        //影院类
        Cinema cinema = new Cinema();
        //保存影院的座位信息
        Seat seat1 = new Seat();
        private void 获取新放映列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            sd.LoadItems();//调用 放映计划类        
            InitTreeView();//遍历绑定Treeview值
            emply();//调用赋空值
            this.groupBox2.Enabled = false;
            this.cboStudent.Text = null;
            
        }
        //初始化TreeView控件
        private void InitTreeView()
        {
            tvlist.Nodes.Clear();
            string moviename = string.Empty;
            //绑定TreeView
            TreeNode node = null;
            //遍历每场电影的信息
            foreach (ScheduleItem item in sd.Items.Values)
            {
                //如果控件里的变量名不等与xml里的名字
                if (moviename!= item.Movie.MovieName)
                {
                    //
                    node = new TreeNode(item.Movie.MovieName);
                    this.tvlist.Nodes.Add(node);
                }
                TreeNode timenode = new TreeNode(item.Time);
                node.Nodes.Add(timenode);
                moviename = item.Movie.MovieName;
               
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            seat();//放映厅座位
            emply();//赋空
            
        }
        Label label = null; 
        //放映厅座位
        //动态加载label标签座位
        public void seat()
        {

            cinema.Seats.Clear();        
            labels.Clear();
            tabPage2.Controls.Clear();
            for (int i = 0; i < 5; i++)//行
            {
                for (int j = 0; j < 7; j++)//列
                {
                    label = new Label();
                    label.BackColor = Color.Yellow;
                    //字体
                    label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    //设置尺寸
                    label.AutoSize = false;
                    label.Size = new System.Drawing.Size(50,25);
                    //设置座位号
                    label.Text = (j + 1).ToString() + "_" + (i + 1).ToString();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    //设置位置
                    label.Location = new Point(50+(i*110),30+(j*70));
                    //所有的标签都绑定到同一事件
                    label.Click += new System.EventHandler(llblSeat_Click);
                    tabPage2.Controls.Add(label);
                    //绑定到label集合中去
                    labels.Add(label.Text,label);
                    //实例化一个Seat座位，的参数为座位及颜色
                    seat1 = new Seat((j+1).ToString()+"_"+(i+1).ToString(),Color.Yellow);
                    //保存的座位集合
                    cinema.Seats.Add(seat1.SeatNum,seat1);

                    
                }
            }
        }
        //遍历该场电影的已售票集合(继续购票的作用)
        public void timecolor()
        {

            foreach (Ticket item in cinema.SoldTickets)
            {
                foreach (Seat seat2 in cinema.Seats.Values)
                {
                    //放映场次的时间==选择的时间
                    if (item.ScheduleItem.Time == Key && (item.Seat.SeatNum == seat2.SeatNum))
                    {
                        seat2.Color = Color.Red;
                    }
                    
                }
            }
        }
        //购票     
        private void llblSeat_Click(object sender, EventArgs e)
        {
            Show(sender);
           
        }
        //购票
        public void Show(object sender)
        {
            try
            {
                string seatNum = ((Label)sender).Text.ToString();//在第几座名字
                string customerName = this.txtgive.Text.ToString();//赠送者
                int discount = 0;
                string type = "";
                if (this.rboStudent.Checked)
                {
                    type = "student";
                    if (this.cboStudent.Text == null)
                    {
                        MessageBox.Show("请输入折扣！");
                        return;
                    }
                    else
                    {
                        discount = int.Parse(this.cboStudent.Text);
                    }
                }
                else if (this.rbocomplimentaryticket.Checked)
                {
                    if (String.IsNullOrEmpty(this.txtgive.Text))
                    {
                        MessageBox.Show("请输入赠票者的姓名！");
                        return;
                    }
                    else
                    {
                        type = "free";
                    }
                }
                string Key1 = this.tvlist.SelectedNode.Text;
                //调用工具类创建票
                Ticket newTicket = TicketUtil.CreateTicket(sd.Items[Key1], cinema.Seats[seatNum], discount, customerName, type);
                if (cinema.Seats[seatNum].Color == Color.Yellow)
                {
                    DialogResult result;
                    result = MessageBox.Show("是否购买？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        cinema.Seats[seatNum].Color = Color.Red;
                        //更新座位状态
                        UpdateSeat();
                        newTicket.CalcPrice();
                        cinema.SoldTickets.Add(newTicket);
                        lblyouhui.Text = newTicket.Price.ToString();
                        //打印影票
                        newTicket.Print();
                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    foreach (Ticket item in cinema.SoldTickets)
                    {
                        if (item.Seat.SeatNum == seatNum && item.ScheduleItem.Time == tvlist.SelectedNode.Text && item.ScheduleItem.Movie.MovieName == tvlist.SelectedNode.Parent.Text)
                        {

                            item.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       
        }
        //更新座位状态
        private void UpdateSeat()
        {
            foreach (string key in cinema.Seats.Keys)
            {
                labels[key].BackColor = cinema.Seats[key].Color;
            }
        }
        //给文本框赋空值
        public void emply()
        {
            this.Name1.Text = null;
            this.lblDirector.Text = null;
            this.lblActor.Text = null;
            this.lbltime.Text = null;
            this.lbltype.Text = null;
            this.lblCalcPrice.Text = null;
            this.lblyouhui.Text = null;
            this.pictureBox1.Image = null;
        }
        //鼠标点击tvlist给文本框赋值
        string Key = string.Empty;
        private void tvlist_AfterSelect(object sender, TreeViewEventArgs e)
        {
           // Show(sender);
            TreeNode node = tvlist.SelectedNode;
            if (node == null) return;
            if (node.Level != 1) return;
            if (tvlist.SelectedNode.Level > 0)
            {
                Key = tvlist.SelectedNode.Text;
                this.Name1.Text = sd.Items[Key].Movie.MovieName;
                this.lblDirector.Text = sd.Items[Key].Movie.Director;
                this.lblActor.Text = sd.Items[Key].Movie.Actor;
                this.lbltime.Text = sd.Items[Key].Time;
                this.lbltype.Text = sd.Items[Key].Movie.MovieType.ToString();
                this.lblCalcPrice.Text = sd.Items[Key].Movie.Price.ToString();
                this.lblyouhui.Text = "";
                this.pictureBox1.Image = Image.FromFile(sd.Items[Key].Movie.Poster);
                
            }
            if (this.tvlist.SelectedNode.Level > 0)
            {
                this.groupBox2.Enabled = true;
            }
         
           
        }    
        private void rbocommon_CheckedChanged(object sender, EventArgs e)
        {
            this.cboStudent.Enabled = false;//打折
            this.txtgive.Enabled = false;//赠送
            this.cboStudent.Text = null;
        }
        private void rbocomplimentaryticket_CheckedChanged(object sender, EventArgs e)
        {
            this.cboStudent.Enabled = false;//打折
            this.txtgive.Enabled = true;//赠送
            this.lblyouhui.Text = "无";
            this.cboStudent.Text =null;
        }
        private void rboStudent_CheckedChanged(object sender, EventArgs e)
        {
            this.cboStudent.Enabled = true;//打折
            this.txtgive.Enabled = false;//赠送         
            string[] add = {"7","8"};
            cboStudent.DataSource =  add;                  
        }             
        private void cboStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.rboStudent.Checked==true)
            {
                int Price = int.Parse(this.lblCalcPrice.Text);
                int discount = int.Parse(this.cboStudent.Text);
                this.lblyouhui.Text = (Price * discount / 10).ToString();
            }
        }
    }
}
