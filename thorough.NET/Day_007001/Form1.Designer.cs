namespace Day_007001
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.userControl11 = new WindowsFormsControlLibrary1.UserControl1();
            this.userControl21 = new Day_007001.UserControl2();
            this.txtContro11 = new Day_007001.txtContro1();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(63, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "3";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(63, 152);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "4";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(63, 193);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "5";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(63, 233);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 0;
            this.textBox6.Text = "6";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(63, 273);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 0;
            this.textBox7.Text = "7";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(63, 309);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 21);
            this.textBox8.TabIndex = 0;
            this.textBox8.Text = "8";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(63, 349);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 21);
            this.textBox9.TabIndex = 0;
            this.textBox9.Text = "9";
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(263, 260);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(340, 168);
            this.userControl11.TabIndex = 3;
            // 
            // userControl21
            // 
            this.userControl21.ForeColor = System.Drawing.Color.Red;
            this.userControl21.Location = new System.Drawing.Point(406, 233);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(100, 21);
            this.userControl21.TabIndex = 2;
            // 
            // txtContro11
            // 
            this.txtContro11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContro11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtContro11.Location = new System.Drawing.Point(406, 152);
            this.txtContro11.MaxLength = 18;
            this.txtContro11.Name = "txtContro11";
            this.txtContro11.Size = new System.Drawing.Size(100, 21);
            this.txtContro11.TabIndex = 1;
            this.txtContro11.TextChanged += new System.EventHandler(this.txtContro11_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 562);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.txtContro11);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private UserControl2 userControl21;
        private txtContro1 txtContro11;
        private WindowsFormsControlLibrary1.UserControl1 userControl11;

    }
}

