namespace WindowsDefenderManager
{
    partial class WD
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnServiceOpen;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WD));
            this.label1 = new System.Windows.Forms.Label();
            this.btnHealthOpen = new System.Windows.Forms.Button();
            this.btnHealthClose = new System.Windows.Forms.Button();
            this.btnServiceClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openSourceLink = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            btnServiceOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnServiceOpen
            // 
            btnServiceOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnServiceOpen.Location = new System.Drawing.Point(58, 191);
            btnServiceOpen.Name = "btnServiceOpen";
            btnServiceOpen.Size = new System.Drawing.Size(75, 38);
            btnServiceOpen.TabIndex = 4;
            btnServiceOpen.Text = "开启";
            btnServiceOpen.UseVisualStyleBackColor = true;
            btnServiceOpen.Click += new System.EventHandler(this.btnServiceOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Windows Defender 安全健康服务管理";
            // 
            // btnHealthOpen
            // 
            this.btnHealthOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHealthOpen.Location = new System.Drawing.Point(58, 82);
            this.btnHealthOpen.Name = "btnHealthOpen";
            this.btnHealthOpen.Size = new System.Drawing.Size(75, 38);
            this.btnHealthOpen.TabIndex = 1;
            this.btnHealthOpen.Text = "开启";
            this.btnHealthOpen.UseVisualStyleBackColor = true;
            this.btnHealthOpen.Click += new System.EventHandler(this.btnHealthOpen_Click);
            // 
            // btnHealthClose
            // 
            this.btnHealthClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHealthClose.Location = new System.Drawing.Point(173, 82);
            this.btnHealthClose.Name = "btnHealthClose";
            this.btnHealthClose.Size = new System.Drawing.Size(75, 38);
            this.btnHealthClose.TabIndex = 2;
            this.btnHealthClose.Text = "关闭";
            this.btnHealthClose.UseVisualStyleBackColor = true;
            this.btnHealthClose.Click += new System.EventHandler(this.btnHealthClose_Click);
            // 
            // btnServiceClose
            // 
            this.btnServiceClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServiceClose.Location = new System.Drawing.Point(173, 191);
            this.btnServiceClose.Name = "btnServiceClose";
            this.btnServiceClose.Size = new System.Drawing.Size(75, 38);
            this.btnServiceClose.TabIndex = 5;
            this.btnServiceClose.Text = "关闭";
            this.btnServiceClose.UseVisualStyleBackColor = true;
            this.btnServiceClose.Click += new System.EventHandler(this.btnServiceClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Windows Defender 安全服务中心管理";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(334, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "一键开启/关闭您的Windows Defender";
            // 
            // openSourceLink
            // 
            this.openSourceLink.AutoSize = true;
            this.openSourceLink.Location = new System.Drawing.Point(528, 289);
            this.openSourceLink.Name = "openSourceLink";
            this.openSourceLink.Size = new System.Drawing.Size(108, 13);
            this.openSourceLink.TabIndex = 8;
            this.openSourceLink.TabStop = true;
            this.openSourceLink.Text = "Github 开源地址";
            this.openSourceLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openSourceLink_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(697, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "By 亦泽";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Salmon;
            this.label5.Location = new System.Drawing.Point(90, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "请以管理员权限运行";
            // 
            // WD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 324);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.openSourceLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnServiceClose);
            this.Controls.Add(btnServiceOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHealthClose);
            this.Controls.Add(this.btnHealthOpen);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WD";
            this.Text = "Windows Defender Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHealthOpen;
        private System.Windows.Forms.Button btnHealthClose;
        private System.Windows.Forms.Button btnServiceClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel openSourceLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

