namespace WindowsFormsControlLibrary1
{
    partial class UserControl1
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtControl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtControl
            // 
            this.txtControl.Location = new System.Drawing.Point(0, 3);
            this.txtControl.Name = "txtControl";
            this.txtControl.Size = new System.Drawing.Size(135, 21);
            this.txtControl.TabIndex = 0;
            this.txtControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtControl_KeyPress);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtControl);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(137, 25);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtControl;


    }
}
