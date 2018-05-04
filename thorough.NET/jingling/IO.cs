using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace jingling
{
    public partial class IO : Form
    {
        public IO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    string path = this.txtPath.Text;
        //    FileStream fs = new FileStream(path,FileMode.Open);
        //    StreamReader sr = new StreamReader(fs,Encoding.Default);
        //    string countent = sr.ReadToEnd();
        //    this.txtCoent.Text = countent;
        //    sr.Close();
        //    fs.Close();




            this.openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            if (path.Equals(null)||path.Equals(""))
            {
                MessageBox.Show("文件地址不能为空！！");
                return;
            }
            try
            {
                //创建文件流
                FileStream fs = new FileStream(path,FileMode.Open);
                //创建写入器
                StreamReader sr = new StreamReader(fs,Encoding.Default);
                //读取文件的所有内容

                string content = sr.ReadToEnd();
                txtCoent.Text = content;
                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //路径文件地址
            string path = txtPath.Text;
            //显示的内容
            string content = txtCoent.Text;
            if (path.Equals(null) || path.Equals(""))
            {
                MessageBox.Show("不能为空");
                return;
            }
            try
            {
                //创建文件流
                FileStream myfs = new FileStream(path, FileMode.Create);
                //创建写入器
                StreamWriter mysw = new StreamWriter(myfs, Encoding.Default);
                //将录入的内容写入文件
                mysw.Write(content);
                mysw.Close();
                myfs.Close();
                MessageBox.Show("写入成功");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
