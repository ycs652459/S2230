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
    public partial class FrmAdd : Form
    {


       
        //
        public FrmAdd()
        {
            InitializeComponent();

            this.cboSex.SelectedIndex = 0;
        }
        /// <summary>
        /// 保存的按钮   
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         public int type;
        //保存父窗体的引用
        public FrmMain FrmParent { get; set; }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                //创建SE的对象
                SE se = new SE();
                se.ID = this.txtid.Text.Trim();
                se.Age = Int32.Parse(this.txtAge.Text.Trim());
                se.Name = this.txtName.Text.Trim();//姓名
                if (this.cboSex.SelectedItem.ToString() == "男")
                {
                    se.Gender = Gender.男.ToString();
                }
                else
                {
                    se.Gender = Gender.女.ToString();
                }
                //循环打印
                foreach (SE item in FrmParent.AddList)
                {
                    if (item.ID == se.ID)
                    {
                        MessageBox.Show("此工号已经存在！");
                        return;
                    }
                }
                //添加泛型集合里
                FrmParent.AddList.Add(se);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                //刷新列表
                this.FrmParent.BindGrid(FrmParent.AddList);
            }
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {

        }

        private void cboSex_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
