namespace NetSpy
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
            this.components = new System.ComponentModel.Container();
            this.tvlsit = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加到我的电台ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabprogram = new System.Windows.Forms.TabPage();
            this.dgvlist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabprogram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).BeginInit();
            this.SuspendLayout();
            // 
            // tvlsit
            // 
            this.tvlsit.ContextMenuStrip = this.contextMenuStrip1;
            this.tvlsit.Location = new System.Drawing.Point(11, 42);
            this.tvlsit.Name = "tvlsit";
            this.tvlsit.Size = new System.Drawing.Size(205, 433);
            this.tvlsit.TabIndex = 0;
            this.tvlsit.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvlsit_AfterSelect);
            this.tvlsit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvlsit_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加到我的电台ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 48);
            // 
            // 添加到我的电台ToolStripMenuItem
            // 
            this.添加到我的电台ToolStripMenuItem.Name = "添加到我的电台ToolStripMenuItem";
            this.添加到我的电台ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.添加到我的电台ToolStripMenuItem.Text = "添加到我的电台";
            this.添加到我的电台ToolStripMenuItem.Click += new System.EventHandler(this.添加到我的电台ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabprogram);
            this.tabControl1.Location = new System.Drawing.Point(236, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(443, 434);
            this.tabControl1.TabIndex = 1;
            // 
            // tabprogram
            // 
            this.tabprogram.Controls.Add(this.dgvlist);
            this.tabprogram.Location = new System.Drawing.Point(4, 22);
            this.tabprogram.Name = "tabprogram";
            this.tabprogram.Padding = new System.Windows.Forms.Padding(3);
            this.tabprogram.Size = new System.Drawing.Size(435, 408);
            this.tabprogram.TabIndex = 0;
            this.tabprogram.Text = "节目";
            this.tabprogram.UseVisualStyleBackColor = true;
            // 
            // dgvlist
            // 
            this.dgvlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvlist.Location = new System.Drawing.Point(3, 6);
            this.dgvlist.Name = "dgvlist";
            this.dgvlist.ReadOnly = true;
            this.dgvlist.RowTemplate.Height = 23;
            this.dgvlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlist.Size = new System.Drawing.Size(429, 399);
            this.dgvlist.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Playtime";
            this.Column1.HeaderText = "播放时间";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "节目名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 489);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tvlsit);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网络精灵";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabprogram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvlsit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabprogram;
        private System.Windows.Forms.DataGridView dgvlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加到我的电台ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

