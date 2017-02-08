namespace MyKTV
{
    partial class FrmAdmin
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("热门流行");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("经典老歌");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("影视金曲");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("游戏动漫");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("戏曲");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("儿歌");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("歌曲", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("男");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("女");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("组合");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("华语", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("男");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("女");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("组合");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("日本", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("男");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("女");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("组合");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("欧美", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("男");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("女");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("组合");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("韩国", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("歌手", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode15,
            treeNode19,
            treeNode23});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SingerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongAB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongWordCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongPlayCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.explorerBar1 = new DevComponents.DotNetBar.ExplorerBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explorerBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(41, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "后台管理登录界面";
            // 
            // txtAdmin
            // 
            this.txtAdmin.Location = new System.Drawing.Point(115, 91);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(173, 25);
            this.txtAdmin.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.White;
            this.txtPwd.Location = new System.Drawing.Point(115, 168);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(173, 25);
            this.txtPwd.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "登录";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(384, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1521, 760);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1521, 760);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点2";
            treeNode1.Text = "热门流行";
            treeNode2.Name = "节点3";
            treeNode2.Text = "经典老歌";
            treeNode3.Name = "节点4";
            treeNode3.Text = "影视金曲";
            treeNode4.Name = "节点5";
            treeNode4.Text = "游戏动漫";
            treeNode5.Name = "节点6";
            treeNode5.Text = "戏曲";
            treeNode6.Name = "节点7";
            treeNode6.Text = "儿歌";
            treeNode7.Name = "节点0";
            treeNode7.Text = "歌曲";
            treeNode8.Name = "节点12";
            treeNode8.Text = "男";
            treeNode9.Name = "节点13";
            treeNode9.Text = "女";
            treeNode10.Name = "节点17";
            treeNode10.Text = "组合";
            treeNode11.Name = "节点8";
            treeNode11.Text = "华语";
            treeNode12.Name = "节点14";
            treeNode12.Text = "男";
            treeNode13.Name = "节点15";
            treeNode13.Text = "女";
            treeNode14.Name = "节点16";
            treeNode14.Text = "组合";
            treeNode15.Name = "节点9";
            treeNode15.Text = "日本";
            treeNode16.Name = "节点18";
            treeNode16.Text = "男";
            treeNode17.Name = "节点19";
            treeNode17.Text = "女";
            treeNode18.Name = "节点20";
            treeNode18.Text = "组合";
            treeNode19.Name = "节点10";
            treeNode19.Text = "欧美";
            treeNode20.Name = "节点21";
            treeNode20.Text = "男";
            treeNode21.Name = "节点22";
            treeNode21.Text = "女";
            treeNode22.Name = "节点23";
            treeNode22.Text = "组合";
            treeNode23.Name = "节点11";
            treeNode23.Text = "韩国";
            treeNode24.Name = "节点1";
            treeNode24.Text = "歌手";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode24});
            this.treeView1.Size = new System.Drawing.Size(206, 760);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1142, 730);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "退出";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SingerName,
            this.SingerTypeName,
            this.SingerSex,
            this.SingerURL,
            this.SongName,
            this.SongURL,
            this.SongAB,
            this.SongWordCount,
            this.SongTypeName,
            this.SongPlayCount});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1311, 724);
            this.dataGridView1.TabIndex = 0;
            // 
            // SingerName
            // 
            this.SingerName.DataPropertyName = "SingerName";
            this.SingerName.HeaderText = "歌手姓名";
            this.SingerName.Name = "SingerName";
            this.SingerName.ReadOnly = true;
            // 
            // SingerTypeName
            // 
            this.SingerTypeName.DataPropertyName = "SingerTypeName";
            this.SingerTypeName.HeaderText = "歌手地区类型";
            this.SingerTypeName.Name = "SingerTypeName";
            this.SingerTypeName.ReadOnly = true;
            // 
            // SingerSex
            // 
            this.SingerSex.DataPropertyName = "SingerSex";
            this.SingerSex.HeaderText = "歌手类型";
            this.SingerSex.Name = "SingerSex";
            this.SingerSex.ReadOnly = true;
            // 
            // SingerURL
            // 
            this.SingerURL.DataPropertyName = "SingerURL";
            this.SingerURL.HeaderText = "歌手照片路径";
            this.SingerURL.Name = "SingerURL";
            this.SingerURL.ReadOnly = true;
            // 
            // SongName
            // 
            this.SongName.DataPropertyName = "SongName";
            this.SongName.HeaderText = "歌曲名称";
            this.SongName.Name = "SongName";
            this.SongName.ReadOnly = true;
            // 
            // SongURL
            // 
            this.SongURL.DataPropertyName = "SongURL";
            this.SongURL.HeaderText = "歌曲存放路径";
            this.SongURL.Name = "SongURL";
            this.SongURL.ReadOnly = true;
            // 
            // SongAB
            // 
            this.SongAB.DataPropertyName = "SongAB";
            this.SongAB.HeaderText = "歌曲名称拼音缩写";
            this.SongAB.Name = "SongAB";
            this.SongAB.ReadOnly = true;
            // 
            // SongWordCount
            // 
            this.SongWordCount.DataPropertyName = "SongWordCount";
            this.SongWordCount.HeaderText = "歌曲名字长度";
            this.SongWordCount.Name = "SongWordCount";
            this.SongWordCount.ReadOnly = true;
            // 
            // SongTypeName
            // 
            this.SongTypeName.DataPropertyName = "SongTypeName";
            this.SongTypeName.HeaderText = "歌曲类型";
            this.SongTypeName.Name = "SongTypeName";
            this.SongTypeName.ReadOnly = true;
            // 
            // SongPlayCount
            // 
            this.SongPlayCount.DataPropertyName = "SongPlayCount";
            this.SongPlayCount.HeaderText = "歌曲点击数";
            this.SongPlayCount.Name = "SongPlayCount";
            this.SongPlayCount.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtAdmin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtPwd);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 283);
            this.panel2.TabIndex = 4;
            // 
            // explorerBar1
            // 
            this.explorerBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.explorerBar1.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.explorerBar1.BackStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground2;
            this.explorerBar1.BackStyle.BackColorGradientAngle = 90;
            this.explorerBar1.BackStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground;
            this.explorerBar1.BackStyle.Class = "";
            this.explorerBar1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.explorerBar1.GroupImages = null;
            this.explorerBar1.Images = null;
            this.explorerBar1.Location = new System.Drawing.Point(-19, -19);
            this.explorerBar1.Name = "explorerBar1";
            this.explorerBar1.Size = new System.Drawing.Size(75, 23);
            this.explorerBar1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors;
            this.explorerBar1.TabIndex = 5;
            this.explorerBar1.Text = "explorerBar1";
            this.explorerBar1.ThemeAware = true;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1932, 1092);
            this.Controls.Add(this.explorerBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explorerBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongAB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongWordCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongPlayCount;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private DevComponents.DotNetBar.ExplorerBar explorerBar1;
    }
}