using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;      
namespace jingling
{
    public partial class DBA : Form
    {
        public DBA()
        {
            InitializeComponent();
        }
      
        private void tvlist_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //在tvlist选择的当前的节点
            TreeNode node = this.tvlist.SelectedNode;
            this.BindInfo(node);
        }
        //将目录TreeView中和子目录绑到listView中
        public void BindInfo(TreeNode node)
        {
            //绑定子目录
            DirectoryInfo directoryInfo = new DirectoryInfo(node.Tag.ToString());
            //返回当前目录的子目录
            DirectoryInfo[] dirc = directoryInfo.GetDirectories();
            node.Nodes.Clear();
            foreach (DirectoryInfo item in dirc)
            {
                TreeNode temp = new TreeNode();
                temp.Text = item.Name;
                temp.Tag = item.FullName;//完整的路径
                node.Nodes.Add(temp);
            }
            //得到当前的子文件
            FileInfo[] fi = directoryInfo.GetFiles();
            //为了不让它重复出现
            lvlist.Items.Clear();
            //循环到listVilw中
            foreach (FileInfo item in fi)
            {
                ListViewItem list = new ListViewItem();
                list.Text = item.Name;//文件名字
                list.SubItems.Add((item.Length / 1024.0).ToString());//大小
                list.SubItems.Add(item.Extension);//类型
               
                list.SubItems.Add(item.FullName);//路径 
                lvlist.Items.Add(list);
            }
        }
        
        private void DBA_Load(object sender, EventArgs e)
        {

            DriveInfo[] drivers = DriveInfo.GetDrives(); //获得整个系统磁盘驱动

            //将盘符名加载到TreeView的顶级节点
            foreach (DriveInfo driver in drivers)
            {
                TreeNode node = new TreeNode(driver.Name);
                node.Tag = driver.Name;
                this.tvlist.Nodes.Add(node);
            }
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //复制文件
            //浏览文件的对话框
            if (this.lvlist.SelectedItems.Count == 0)
            {
                return;
            }
            //提示用户选择目标文件夹
            FolderBrowserDialog fl = new FolderBrowserDialog();
            DialogResult result = fl.ShowDialog();
            //判断是否用户点击的是确定键
            if (result == DialogResult.OK)
            {
                //原路径
                string sourcePath = lvlist.SelectedItems[0].SubItems[3].Text;
                //目标的文件路径
                string desPath = null;
                //打开对话框你要选择复制的新的路径
                desPath = fl.SelectedPath;
                //lvlist表示显示文件信息的ListView对象
                desPath += "\\" + lvlist.SelectedItems[0].SubItems[0].Text;
                File.Copy(sourcePath,desPath,true);
                MessageBox.Show("复制成功！");
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvlist.SelectedItems.Count> 0)
            {
            DialogResult resuot = MessageBox.Show("确定要删除此文件吗？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (resuot == DialogResult.OK)
            {
                string path = lvlist.SelectedItems[0].SubItems[3].Text;
                File.Delete(path);
                //删除lvlist的数据
                lvlist.SelectedItems[0].Remove();
            }
            }
        }

        private void lvlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //鼠标双击的事件的发生
        private void lvlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //创建打开文件框的对象
            OpenFileDialog open = new OpenFileDialog();
            //获取路径
            string path = lvlist.SelectedItems[0].SubItems[3].Text;
           
            //目的就是想通过指定资源管理器打开指定的地址。expporer:打开资源管理器
            System.Diagnostics.Process.Start("explorer.exe", path);
             
        }
    }
}
