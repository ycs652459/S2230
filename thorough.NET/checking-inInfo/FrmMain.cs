using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checking_inInfo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public Dictionary<string, Record> dic = new Dictionary<string, Record>();
        //泛型集合
        public List<SE> AddList = new List<SE>();
        //刷新DataGridView数据
        public void BindGrid(List<SE> list)
        {
            this.divList.DataSource = new BindingList<SE>(list);
            
        }
        //主窗口
        private void FrmMain_Load(object sender, EventArgs e)
        {
           
        }
        //新增
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmAdd fm = new FrmAdd();
            fm.type = 1;
            fm.FrmParent = this;
            fm.ShowDialog();
        }
        //查看
        private void btnLook_Click(object sender, EventArgs e)
        {
            List<SE> tempList = new List<SE>();//用于临时列表保存查询到的信息
            foreach (SE item in this.AddList)
            {
                //如果泛型集合的SE下标不等于-1
                if (item.ID.IndexOf(this.txtId.Text.Trim()) !=-1)
                {
                    tempList.Add(item);
                }
            }
            this.divList.DataSource = new BindingList<SE>(tempList);

        }
        //删除
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("是否确定删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                //通过索引访问
                List<SE> tempList = new List<SE>();
                //拿到选中的员工号进行删除
                string id = this.divList.SelectedRows[0].Cells[0].Value.ToString();
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i].ID == id)
                    {
                        //执行删除操作
                        tempList.Remove(tempList[i]);
                        //刷新DataGridView
                      
                    }
                }
                BindGrid(tempList);
                MessageBox.Show("删除成功！");
                     
            }
        }
        
          
        //修改
        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
      

        private void 签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断是否选中一行
            if (this.divList.SelectedRows.Count != 1)
            {
                MessageBox.Show("请选中一行！");
                return;
            }
            string workNo = divList.CurrentRow.Cells[0].Value.ToString();
            //遍历Key值
            foreach (string item in dic.Keys)
            {
                if (workNo == item)
                {
                    MessageBox.Show("您已经签到过！");
                    return;
                }
            }
            Record record = new Record();

            record.ID = workNo;//id号

            record.Name = divList.CurrentRow.Cells[1].Value.ToString();//获取选中的姓名
            record.SignInTime = DateTime.Now;//当前的时间
            this.dic.Add(record.ID,record);//添加到记录里
            MessageBox.Show("签到成功！");

        }

        private void 签退ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.divList.SelectedRows.Count !=1)
            {
                MessageBox.Show("请选择一行！");
                return;
            }
            string ID = divList.CurrentRow.Cells[0].Value.ToString();
            bool isOut = false;//标识是否已经签到过
            foreach (string item in dic.Keys)
            {
                if (item == ID)
                {
                    this.dic[item].SignOutTime = DateTime.Now;
                    MessageBox.Show("签退成功！");
                    isOut = true;
                    break;
                }
            }


            if (!isOut)
            {
                MessageBox.Show("很抱歉，尚未签到！");
            }
        }
        //打卡记录
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Frmclock fm = new Frmclock();
            fm.FrmParent = this;
            fm.ShowDialog();
        }
    }
}
