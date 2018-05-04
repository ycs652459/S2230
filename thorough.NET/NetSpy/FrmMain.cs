using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSpy
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "MacOS.ssk";

        }
        ChannelManager cm = new ChannelManager();
        //主窗口
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //去掉多余的列
            this.dgvlist.AutoGenerateColumns = false;
            Info();
        }
        //初始化
        public void Info()
        {
            //初始化根结点
            TreeNode nodeFirstLevel = new TreeNode("我的电视台");
            nodeFirstLevel.ImageIndex = 0;
            this.tvlsit.Nodes.Add(nodeFirstLevel);
            nodeFirstLevel = new TreeNode("所有电视台");
            this.tvlsit.Nodes.Add(nodeFirstLevel);
            //调用频道的方法*91
            cm.LoadChannel();
            //将所有频道名称加到所有电视台
           

            foreach (ChannelBase dicOne in cm.dic.Values)
            {
                TreeNode node = new TreeNode();
                node.Text = dicOne.ChanName;
                node.Tag = dicOne;
                node.ImageIndex = 1;
                this.tvlsit.Nodes[1].Nodes.Add(node);

            }
            //foreach (var item in cm.dic)
            //{
            //    tvlsit.Nodes[1].Nodes.Add(item.Key);
            //}
            //加载到我的电台
            foreach (ChannelBase dicOne in cm.Seria.MyFavor)
            {
                TreeNode node = new TreeNode();
                node.Text = dicOne.ChanName;
                node.Tag = dicOne;
                node.ImageIndex = 1;
                this.tvlsit.Nodes[0].Nodes.Add(node);
            }

            //展开所有节点
            tvlsit.ExpandAll();
        }

        private void tvlsit_AfterSelect(object sender, TreeViewEventArgs e)
        {

            BangChannel();      

        }


        public void BangChannel()
        {
           
            if (tvlsit.SelectedNode.Level == 0)
            {
                dgvlist.DataSource = null;
                return;
            }
            else
            {
                //用选中的频道找 节目列表
                dgvlist.DataSource = cm.dic[tvlsit.SelectedNode.Text].ProgramList;
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tvlsit.SelectedNode.Remove();
        }

        private void 添加到我的电台ToolStripMenuItem_Click(object sender, EventArgs e)
        {        
            foreach (TreeNode item in tvlsit.Nodes[0].Nodes)
            {
                if (item.Text.Equals(tvlsit.SelectedNode.Text))
                {
                    MessageBox.Show("已经有该频道了！");
                    return;
                }
            }
            tvlsit.Nodes[0].Nodes.Add(tvlsit.SelectedNode.Text);
            //tvlsit.SelectedNode.Remove();
        }
        //鼠标单击发生的事件
        private void tvlsit_MouseClick(object sender, MouseEventArgs e)
        {
            //如果选中的是我的电视台的子节点则把 删除 显示   ， 加入 隐藏
            if (tvlsit.SelectedNode.Parent != null && tvlsit.SelectedNode.Parent.Text.Equals("所有电视台"))
            {
                contextMenuStrip1.Items[0].Visible = true;//删除
                contextMenuStrip1.Items[1].Visible = false;//添加到我的电视台
            }
            //如果选中的是所有电视台的子节点则把 隐藏 显示 ， 删除 隐藏
            else
            {
                contextMenuStrip1.Items[0].Visible = false;//删除
                contextMenuStrip1.Items[1].Visible = true;//添加到我的电视台
            }
            //如果选中的是根则把 两个 都隐藏
            if (tvlsit.SelectedNode.Level == 0)
            {
                contextMenuStrip1.Items[0].Visible = false;
                contextMenuStrip1.Items[1].Visible = false;
            }



        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            cm.SaveAsTxt();
            Application.Exit();
        }
    }
}