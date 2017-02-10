namespace MyKTV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.wmpKTV = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.ptbAdd = new System.Windows.Forms.PictureBox();
            this.ptbJian = new System.Windows.Forms.PictureBox();
            this.ptbMute = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ptbMute1 = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wmpKTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbJian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMute1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(288, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "分类点歌";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(54, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "拼音点歌";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(288, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "排行榜";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(63, 624);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "播放/暂停";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(250, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "已点";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(579, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "返回";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(488, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "切歌";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(372, 490);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "重播";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // wmpKTV
            // 
            this.wmpKTV.Enabled = true;
            this.wmpKTV.Location = new System.Drawing.Point(724, 12);
            this.wmpKTV.Name = "wmpKTV";
            this.wmpKTV.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpKTV.OcxState")));
            this.wmpKTV.Size = new System.Drawing.Size(350, 300);
            this.wmpKTV.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(809, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "50";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ptbAdd
            // 
            this.ptbAdd.BackColor = System.Drawing.Color.Transparent;
            this.ptbAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbAdd.BackgroundImage")));
            this.ptbAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbAdd.Location = new System.Drawing.Point(943, 324);
            this.ptbAdd.Name = "ptbAdd";
            this.ptbAdd.Size = new System.Drawing.Size(50, 50);
            this.ptbAdd.TabIndex = 5;
            this.ptbAdd.TabStop = false;
            this.ptbAdd.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ptbJian
            // 
            this.ptbJian.BackColor = System.Drawing.Color.Transparent;
            this.ptbJian.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbJian.BackgroundImage")));
            this.ptbJian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbJian.Location = new System.Drawing.Point(753, 324);
            this.ptbJian.Name = "ptbJian";
            this.ptbJian.Size = new System.Drawing.Size(50, 50);
            this.ptbJian.TabIndex = 6;
            this.ptbJian.TabStop = false;
            this.ptbJian.Click += new System.EventHandler(this.ptbJian_Click);
            // 
            // ptbMute
            // 
            this.ptbMute.BackColor = System.Drawing.Color.Transparent;
            this.ptbMute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbMute.BackgroundImage")));
            this.ptbMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbMute.Location = new System.Drawing.Point(1010, 324);
            this.ptbMute.Name = "ptbMute";
            this.ptbMute.Size = new System.Drawing.Size(50, 50);
            this.ptbMute.TabIndex = 5;
            this.ptbMute.TabStop = false;
            this.ptbMute.Click += new System.EventHandler(this.ptbMute_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(35, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "正在播放";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(274, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "下一首";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(724, 279);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 33);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(357, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 25);
            this.textBox2.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(652, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "后台";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Yellow;
            this.label13.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(772, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(319, 28);
            this.label13.TabIndex = 0;
            this.label13.Text = "欢迎使用MyKTV点歌系统";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(54, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "歌手点歌";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(54, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "字数点歌";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ptbMute1
            // 
            this.ptbMute1.BackColor = System.Drawing.Color.Transparent;
            this.ptbMute1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbMute1.BackgroundImage")));
            this.ptbMute1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbMute1.Location = new System.Drawing.Point(1010, 399);
            this.ptbMute1.Name = "ptbMute1";
            this.ptbMute1.Size = new System.Drawing.Size(50, 50);
            this.ptbMute1.TabIndex = 5;
            this.ptbMute1.TabStop = false;
            this.ptbMute1.Click += new System.EventHandler(this.ptbMute_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Transparent;
            this.stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stop.BackgroundImage")));
            this.stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stop.Location = new System.Drawing.Point(71, 552);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(50, 50);
            this.stop.TabIndex = 5;
            this.stop.TabStop = false;
            this.stop.Click += new System.EventHandler(this.ptbMute_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("play.BackgroundImage")));
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.play.Location = new System.Drawing.Point(71, 496);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(50, 50);
            this.play.TabIndex = 5;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.ptbMute_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1086, 659);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ptbJian);
            this.Controls.Add(this.ptbMute1);
            this.Controls.Add(this.play);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.ptbMute);
            this.Controls.Add(this.ptbAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wmpKTV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpKTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbJian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMute1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private AxWMPLib.AxWindowsMediaPlayer wmpKTV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ptbAdd;
        private System.Windows.Forms.PictureBox ptbJian;
        private System.Windows.Forms.PictureBox ptbMute;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ptbMute1;
        private System.Windows.Forms.PictureBox stop;
        private System.Windows.Forms.PictureBox play;
    }
}

