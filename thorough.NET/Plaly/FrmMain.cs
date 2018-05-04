using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plaly
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //选择一行
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            List<Song> list = new List<Song>()
            {
                new Song("林俊杰 - 当你.mp3", "E:\\C#\\MyKTV\\Music\\林俊杰 - 当你.mp3"),
                new Song("陈奕迅 - 不要说话.mp3", "E:\\C#\\MyKTV\\Music\\陈奕迅 - 不要说话.mp3")
            };
            dgvList.DataSource = new BindingList<Song>(list);
        }

        private void 播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlary fm = FrmPlary.getInstance();
            fm.Path = dgvList.SelectedRows[0].Cells[1].Value.ToString();
            fm.PlaySong();
            fm.Show();

        }
    }
}
