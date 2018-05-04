using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thorought.NET.xiangm
{
    public partial class FrmShow : Form
    {
        //定义数组
        public SE[] en = new SE[3];
        public FrmShow()
        {
            InitializeComponent();
            
        }

        public void Init()
        {
            SE SB = new SE();
            SB.Number = 11;
            SB.Name = "离散";
            SB.Age = 26;
            SB.Grade = "为评价";
            SB.Manager = 0;
            en[0] = SB;
            //2
            SE SB1 = new SE();
            SB1.Number = 12;
            SB1.Name = "阿达";
            SB1.Age = 22;
            SB1.Grade = "未评价";
            SB1.Manager = 0;
            en[1] = SB1;
            //3
            SE SB2 = new SE();
            SB2.Number = 13;
            SB2.Name = "释放";
            SB2.Age = 25;
            SB2.Grade = "未评价";
            SB2.Manager = 0;
            en[2] = SB2;
        }
        public void UpdateView()
        {
            ////清除原有的数据
            //listView1.Items.Clear();
            //for (int i = 0; i < en.Length; i++)
            //{
            //    //
            //    if (en[i] != null)
            //    {
            //        //向控件上赋值
            //        ListViewItem item = new ListViewItem(en[i].Number.ToString());
            //        item.SubItems.Add(en[i].Name);
            //        item.SubItems.Add(en[i].Age.ToString());
            //        item.SubItems.Add(en[i].Grade);
            //        item.SubItems.Add(en[i].Manager.ToString());
            //        listView1.Items.Add(item);
            //    }
        //}
            foreach (var item in en)
    {
         ListViewItem list = new ListViewItem(item.Number.ToString());
                list.SubItems.Add(item.Name);
                list.SubItems.Add(item.Age.ToString());
                list.SubItems.Add(item.Grade);
                list.SubItems.Add(item.Manager.ToString());
                 listView1.Items.Add(list);
    }
                                  
            
            }
        
        /// <summary>
        /// 主窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmShow_Load(object sender, EventArgs e)
        {
            Init();
            UpdateView();
            
        }
        //双击listView1的事件
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////判断是否选择了一行
            //if (this.listView1.SelectedItems.Count == 0)
            //{
            //    return;//必须有一行
                
            //}
            //int index = 0;
            //for (int i = 0; i < en.Length; i++)
            //{
            //    if (en[i].Number.Equals(this.listView1.SelectedItems[0].Text.Trim()))
            //    {
            //        index = i;
            //        break;
            //    }
            //}
            //FrmJudge fm = new FrmJudge(this, index);
            //fm.Show();
            //对选中的是一整行
         ListViewItem item = listView1.SelectedItems[0];
         FrmJudge fm = new FrmJudge();
         fm.item = item;
         fm.Show();

        }

    }
}
