namespace thorought.NET.xiangm
{
    partial class FrmJudge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtevaluate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgrade = new System.Windows.Forms.TextBox();
            this.btngrade = new System.Windows.Forms.Button();
            this.btnEsc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工姓名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(146, 26);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(255, 21);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "填写评价";
            // 
            // txtevaluate
            // 
            this.txtevaluate.Location = new System.Drawing.Point(146, 92);
            this.txtevaluate.Multiline = true;
            this.txtevaluate.Name = "txtevaluate";
            this.txtevaluate.Size = new System.Drawing.Size(255, 106);
            this.txtevaluate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "年度评分";
            // 
            // txtgrade
            // 
            this.txtgrade.Location = new System.Drawing.Point(146, 258);
            this.txtgrade.Name = "txtgrade";
            this.txtgrade.Size = new System.Drawing.Size(255, 21);
            this.txtgrade.TabIndex = 2;
            // 
            // btngrade
            // 
            this.btngrade.Location = new System.Drawing.Point(156, 323);
            this.btngrade.Name = "btngrade";
            this.btngrade.Size = new System.Drawing.Size(75, 23);
            this.btngrade.TabIndex = 3;
            this.btngrade.Text = "评价";
            this.btngrade.UseVisualStyleBackColor = true;
            this.btngrade.Click += new System.EventHandler(this.btngrade_Click);
            // 
            // btnEsc
            // 
            this.btnEsc.Location = new System.Drawing.Point(300, 323);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(75, 23);
            this.btnEsc.TabIndex = 3;
            this.btnEsc.Text = "取消";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // FrmJudge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 365);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.btngrade);
            this.Controls.Add(this.txtgrade);
            this.Controls.Add(this.txtevaluate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmJudge";
            this.Text = "FrmJudge";
            this.Load += new System.EventHandler(this.FrmJudge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtevaluate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgrade;
        private System.Windows.Forms.Button btngrade;
        private System.Windows.Forms.Button btnEsc;
    }
}