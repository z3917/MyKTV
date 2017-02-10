using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyKTV
{
    public partial class FrmAdmin : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        public FrmMain main;
        public FrmAdmin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 返回KTV主界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("确定要退出后台登录吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (result==DialogResult.OK)
            {
                this.Close();
            }
        }
        /// <summary>
        /// 登录按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DBHelp.Open();
                string sql = string.Format("SELECT COUNT(*) from Admin where LoginName='{0}' AND LoginPwd='{1}'",txtAdmin.Text,txtPwd.Text);
                SqlCommand cmd = new SqlCommand(sql,DBHelp.Conn);
                int result =Convert.ToInt32( cmd.ExecuteScalar());
                if (result == 1)
                {
                    panel1.Visible = true;
                    panel1.Location = panel2.Location;
                    panel2.Visible = false;
                    this.Size = panel1.Size;
                    this.CenterToScreen();
                }
                else
                {
                    MessageBox.Show("账号或密码不正确！","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            finally
            {
                DBHelp.Close();
            }
        }
       /// <summary>
       /// 详细信息中退出后台
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出后台管理系统吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
        /// <summary>
        /// 窗口加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            this.Size = panel2.Size;
            this.CenterToScreen();
            ds = new DataSet();
            string sql = @"SELECT SingerName,SingerURL,SingerSex,SingerTypeName,SongName,SongURL,SongAB,SongWordCount,SongTypeName,SongPlayCount 
                            FROM SongInfo,SingerInfo,SingerType,SongType
                          WHERE SongInfo.SingerId=SingerInfo.SingerId 
                          AND SongInfo.SongTypeId=SongType.SongTypeId 
                          AND SingerType.SingerTypeId=SingerInfo.SingerTypeId";
            adapter = new SqlDataAdapter(sql,DBHelp.Conn);
            if (ds.Tables["Info"]!=null)
            {
                ds.Tables["Info"].Clear();
            }
            adapter.Fill(ds,"Info");
            dataGridView1.DataSource = ds.Tables["Info"];
        }
        /// <summary>
        /// 根据选中的节点筛选内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Filter();
        }
        /// <summary>
        /// 筛选DataGridView中的内容
        /// </summary>
        private void Filter()
        {
            DataView dv = ds.Tables["Info"].DefaultView;
          
                if (treeView1.SelectedNode.Level==1 &&treeView1.SelectedNode.Parent.Text=="歌曲")
                {
                    dv.RowFilter = string.Format("SongTypeName='{0}'",treeView1.SelectedNode.Text);
                }
                if (treeView1.SelectedNode.Level==1 && treeView1.SelectedNode.Parent.Text == "歌手")
                {
                    dv.RowFilter = string.Format("SingerTypeName='{0}'", treeView1.SelectedNode.Text);
                }
                if (treeView1.SelectedNode.Level==2)
                {
                    dv.RowFilter = string.Format("SingerTypeName='{0}' AND SingerSex='{1}'", treeView1.SelectedNode.Parent.Text,treeView1.SelectedNode.Text);
                }
            
            dataGridView1.DataSource = dv;
        }
    }
}
