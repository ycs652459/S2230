namespace Cinema_ticket
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tvlist = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.购票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.获取新放映列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblyouhui = new System.Windows.Forms.Label();
            this.lblCalcPrice = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblActor = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtgive = new System.Windows.Forms.TextBox();
            this.cboStudent = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rboStudent = new System.Windows.Forms.RadioButton();
            this.rbocomplimentaryticket = new System.Windows.Forms.RadioButton();
            this.rbocommon = new System.Windows.Forms.RadioButton();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.继续售票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(189, 559);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tvlist);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(181, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "放映列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tvlist
            // 
            this.tvlist.Location = new System.Drawing.Point(3, 6);
            this.tvlist.Name = "tvlist";
            this.tvlist.Size = new System.Drawing.Size(172, 519);
            this.tvlist.TabIndex = 0;
            this.tvlist.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvlist_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.购票ToolStripMenuItem,
            this.系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 购票ToolStripMenuItem
            // 
            this.购票ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.获取新放映列表ToolStripMenuItem,
            this.继续售票ToolStripMenuItem});
            this.购票ToolStripMenuItem.Name = "购票ToolStripMenuItem";
            this.购票ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.购票ToolStripMenuItem.Text = "购票";
            // 
            // 获取新放映列表ToolStripMenuItem
            // 
            this.获取新放映列表ToolStripMenuItem.Name = "获取新放映列表ToolStripMenuItem";
            this.获取新放映列表ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.获取新放映列表ToolStripMenuItem.Text = "获取新放映列表";
            this.获取新放映列表ToolStripMenuItem.Click += new System.EventHandler(this.获取新放映列表ToolStripMenuItem_Click);
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblyouhui);
            this.groupBox1.Controls.Add(this.lblCalcPrice);
            this.groupBox1.Controls.Add(this.lbltime);
            this.groupBox1.Controls.Add(this.lbltype);
            this.groupBox1.Controls.Add(this.lblActor);
            this.groupBox1.Controls.Add(this.lblDirector);
            this.groupBox1.Controls.Add(this.Name1);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(197, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 260);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "详情";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(164, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "优惠价";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "原票价";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "放映时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "主演";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "导演";
            // 
            // lblyouhui
            // 
            this.lblyouhui.AutoSize = true;
            this.lblyouhui.ForeColor = System.Drawing.Color.Red;
            this.lblyouhui.Location = new System.Drawing.Point(292, 230);
            this.lblyouhui.Name = "lblyouhui";
            this.lblyouhui.Size = new System.Drawing.Size(41, 12);
            this.lblyouhui.TabIndex = 2;
            this.lblyouhui.Text = "label1";
            // 
            // lblCalcPrice
            // 
            this.lblCalcPrice.AutoSize = true;
            this.lblCalcPrice.Location = new System.Drawing.Point(292, 187);
            this.lblCalcPrice.Name = "lblCalcPrice";
            this.lblCalcPrice.Size = new System.Drawing.Size(41, 12);
            this.lblCalcPrice.TabIndex = 2;
            this.lblCalcPrice.Text = "label1";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(292, 144);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(41, 12);
            this.lbltime.TabIndex = 2;
            this.lbltime.Text = "label1";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(292, 103);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(41, 12);
            this.lbltype.TabIndex = 2;
            this.lbltype.Text = "label1";
            // 
            // lblActor
            // 
            this.lblActor.AutoSize = true;
            this.lblActor.Location = new System.Drawing.Point(292, 67);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(41, 12);
            this.lblActor.TabIndex = 2;
            this.lblActor.Text = "label1";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(292, 28);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(41, 12);
            this.lblDirector.TabIndex = 2;
            this.lblDirector.Text = "label1";
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Location = new System.Drawing.Point(72, 22);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(41, 12);
            this.Name1.TabIndex = 2;
            this.Name1.Text = "label1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "片名";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtgive);
            this.groupBox2.Controls.Add(this.cboStudent);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rboStudent);
            this.groupBox2.Controls.Add(this.rbocomplimentaryticket);
            this.groupBox2.Controls.Add(this.rbocommon);
            this.groupBox2.Location = new System.Drawing.Point(653, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 150);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "特殊票价";
            // 
            // txtgive
            // 
            this.txtgive.Location = new System.Drawing.Point(78, 111);
            this.txtgive.Name = "txtgive";
            this.txtgive.Size = new System.Drawing.Size(144, 21);
            this.txtgive.TabIndex = 3;
            // 
            // cboStudent
            // 
            this.cboStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudent.FormattingEnabled = true;
            this.cboStudent.Location = new System.Drawing.Point(78, 74);
            this.cboStudent.Name = "cboStudent";
            this.cboStudent.Size = new System.Drawing.Size(144, 20);
            this.cboStudent.TabIndex = 2;
            this.cboStudent.SelectedIndexChanged += new System.EventHandler(this.cboStudent_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "赠送者：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "学生折扣：";
            // 
            // rboStudent
            // 
            this.rboStudent.AutoSize = true;
            this.rboStudent.Location = new System.Drawing.Point(164, 25);
            this.rboStudent.Name = "rboStudent";
            this.rboStudent.Size = new System.Drawing.Size(59, 16);
            this.rboStudent.TabIndex = 0;
            this.rboStudent.TabStop = true;
            this.rboStudent.Text = "学生票";
            this.rboStudent.UseVisualStyleBackColor = true;
            this.rboStudent.CheckedChanged += new System.EventHandler(this.rboStudent_CheckedChanged);
            // 
            // rbocomplimentaryticket
            // 
            this.rbocomplimentaryticket.AutoSize = true;
            this.rbocomplimentaryticket.Location = new System.Drawing.Point(85, 24);
            this.rbocomplimentaryticket.Name = "rbocomplimentaryticket";
            this.rbocomplimentaryticket.Size = new System.Drawing.Size(47, 16);
            this.rbocomplimentaryticket.TabIndex = 0;
            this.rbocomplimentaryticket.TabStop = true;
            this.rbocomplimentaryticket.Text = "赠票";
            this.rbocomplimentaryticket.UseVisualStyleBackColor = true;
            this.rbocomplimentaryticket.CheckedChanged += new System.EventHandler(this.rbocomplimentaryticket_CheckedChanged);
            // 
            // rbocommon
            // 
            this.rbocommon.AutoSize = true;
            this.rbocommon.Location = new System.Drawing.Point(9, 25);
            this.rbocommon.Name = "rbocommon";
            this.rbocommon.Size = new System.Drawing.Size(59, 16);
            this.rbocommon.TabIndex = 0;
            this.rbocommon.TabStop = true;
            this.rbocommon.Text = "普通票";
            this.rbocommon.UseVisualStyleBackColor = true;
            this.rbocommon.CheckedChanged += new System.EventHandler(this.rbocommon_CheckedChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(197, 296);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(735, 296);
            this.tabControl2.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(727, 270);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "放映厅";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cinema_ticket.Properties.Resources.青鸟2;
            this.pictureBox2.Location = new System.Drawing.Point(653, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(234, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // 继续售票ToolStripMenuItem
            // 
            this.继续售票ToolStripMenuItem.Name = "继续售票ToolStripMenuItem";
            this.继续售票ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.继续售票ToolStripMenuItem.Text = "继续售票";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 604);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "\"青鸟\"影院售票系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView tvlist;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 购票ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblyouhui;
        private System.Windows.Forms.Label lblCalcPrice;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtgive;
        private System.Windows.Forms.ComboBox cboStudent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rboStudent;
        private System.Windows.Forms.RadioButton rbocomplimentaryticket;
        private System.Windows.Forms.RadioButton rbocommon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem 获取新放映列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 继续售票ToolStripMenuItem;
    }
}

