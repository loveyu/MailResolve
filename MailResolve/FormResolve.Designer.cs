namespace MailResolve
{
    partial class FormSesolve
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
			this.richTextBoxMail = new System.Windows.Forms.RichTextBox();
			this.buttonResolve = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxBcc = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxCc = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxTo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxFrom = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxSubject = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.richTextBoxAtt = new System.Windows.Forms.RichTextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBoxMail
			// 
			this.richTextBoxMail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBoxMail.Location = new System.Drawing.Point(3, 44);
			this.richTextBoxMail.Name = "richTextBoxMail";
			this.richTextBoxMail.Size = new System.Drawing.Size(321, 567);
			this.richTextBoxMail.TabIndex = 0;
			this.richTextBoxMail.Text = "";
			// 
			// buttonResolve
			// 
			this.buttonResolve.Location = new System.Drawing.Point(246, 15);
			this.buttonResolve.Name = "buttonResolve";
			this.buttonResolve.Size = new System.Drawing.Size(75, 23);
			this.buttonResolve.TabIndex = 1;
			this.buttonResolve.Text = "解析";
			this.buttonResolve.UseVisualStyleBackColor = true;
			this.buttonResolve.Click += new System.EventHandler(this.buttonResolve_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonResolve);
			this.groupBox1.Controls.Add(this.richTextBoxMail);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox1.Location = new System.Drawing.Point(10, 10);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 30, 3, 3);
			this.groupBox1.Size = new System.Drawing.Size(327, 614);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "原始邮件";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBoxBcc);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.textBoxCc);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.textBoxTo);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.textBoxFrom);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.textBoxSubject);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(337, 10);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this.groupBox2.MinimumSize = new System.Drawing.Size(10, 10);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(633, 184);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "标头";
			// 
			// textBoxBcc
			// 
			this.textBoxBcc.Location = new System.Drawing.Point(53, 155);
			this.textBoxBcc.Name = "textBoxBcc";
			this.textBoxBcc.Size = new System.Drawing.Size(555, 21);
			this.textBoxBcc.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(18, 158);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 12);
			this.label7.TabIndex = 16;
			this.label7.Text = "密送";
			// 
			// textBoxCc
			// 
			this.textBoxCc.Location = new System.Drawing.Point(53, 122);
			this.textBoxCc.Name = "textBoxCc";
			this.textBoxCc.Size = new System.Drawing.Size(555, 21);
			this.textBoxCc.TabIndex = 19;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 17;
			this.label4.Text = "抄送";
			// 
			// textBoxTo
			// 
			this.textBoxTo.Location = new System.Drawing.Point(53, 86);
			this.textBoxTo.Name = "textBoxTo";
			this.textBoxTo.Size = new System.Drawing.Size(555, 21);
			this.textBoxTo.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 14;
			this.label3.Text = "收信人";
			// 
			// textBoxFrom
			// 
			this.textBoxFrom.Location = new System.Drawing.Point(53, 53);
			this.textBoxFrom.Name = "textBoxFrom";
			this.textBoxFrom.Size = new System.Drawing.Size(555, 21);
			this.textBoxFrom.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 12;
			this.label2.Text = "发信人";
			// 
			// textBoxSubject
			// 
			this.textBoxSubject.Location = new System.Drawing.Point(53, 18);
			this.textBoxSubject.Name = "textBoxSubject";
			this.textBoxSubject.Size = new System.Drawing.Size(555, 21);
			this.textBoxSubject.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 10;
			this.label1.Text = "标题";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.groupBox4);
			this.groupBox3.Controls.Add(this.webBrowser);
			this.groupBox3.Controls.Add(this.richTextBoxContent);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(337, 194);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(633, 430);
			this.groupBox3.TabIndex = 16;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "内容";
			// 
			// webBrowser
			// 
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.Location = new System.Drawing.Point(3, 84);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(627, 343);
			this.webBrowser.TabIndex = 15;
			// 
			// richTextBoxContent
			// 
			this.richTextBoxContent.Dock = System.Windows.Forms.DockStyle.Top;
			this.richTextBoxContent.Location = new System.Drawing.Point(3, 17);
			this.richTextBoxContent.Name = "richTextBoxContent";
			this.richTextBoxContent.Size = new System.Drawing.Size(627, 67);
			this.richTextBoxContent.TabIndex = 12;
			this.richTextBoxContent.Text = "";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.richTextBoxAtt);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox4.Location = new System.Drawing.Point(3, 354);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(627, 73);
			this.groupBox4.TabIndex = 18;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "附件";
			// 
			// richTextBoxAtt
			// 
			this.richTextBoxAtt.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.richTextBoxAtt.Location = new System.Drawing.Point(3, 23);
			this.richTextBoxAtt.Name = "richTextBoxAtt";
			this.richTextBoxAtt.Size = new System.Drawing.Size(621, 47);
			this.richTextBoxAtt.TabIndex = 14;
			this.richTextBoxAtt.Text = "";
			// 
			// FormSesolve
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(980, 634);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormSesolve";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Text = "邮件解析";
			this.Resize += new System.EventHandler(this.FormSesolve_Resize);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxMail;
		private System.Windows.Forms.Button buttonResolve;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxBcc;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxCc;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxTo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxFrom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxSubject;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.RichTextBox richTextBoxContent;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RichTextBox richTextBoxAtt;
    }
}

