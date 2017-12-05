namespace WindowsFormsApplication1
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
            this.corpid = new System.Windows.Forms.TextBox();
            this.secret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.cacheCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // corpid
            // 
            this.corpid.Location = new System.Drawing.Point(108, 73);
            this.corpid.Name = "corpid";
            this.corpid.Size = new System.Drawing.Size(232, 21);
            this.corpid.TabIndex = 0;
            // 
            // secret
            // 
            this.secret.Location = new System.Drawing.Point(108, 120);
            this.secret.Name = "secret";
            this.secret.Size = new System.Drawing.Size(232, 21);
            this.secret.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Secret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "CorpId";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(387, 118);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 3;
            this.createBtn.Text = "添加缓存";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // cacheCount
            // 
            this.cacheCount.Location = new System.Drawing.Point(108, 165);
            this.cacheCount.Name = "cacheCount";
            this.cacheCount.ReadOnly = true;
            this.cacheCount.Size = new System.Drawing.Size(230, 21);
            this.cacheCount.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "缓存数";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "清空时间";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(0, 206);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(598, 175);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 381);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cacheCount);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secret);
            this.Controls.Add(this.corpid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox corpid;
        private System.Windows.Forms.TextBox secret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox cacheCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

