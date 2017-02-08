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
    public partial class Type : Form
    {
        public FrmMain main;
        public string SongType;
        public Type()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 关闭信息窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }
        /// <summary>
        /// 戏曲事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SongType = "戏曲";
            BindType();
        }
        /// <summary>
        /// 窗口加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Type_Load(object sender, EventArgs e)
        {
            panel2.Location = panel1.Location;
        }
        /// <summary>
        /// 绑定DataGridView数据
        /// </summary>
        public void BindType()
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Location = panel1.Location;
            DataSet ds = new DataSet();
            string sql = "SELECT SingerName,SongName,SongURL,SongTypeName FROM SingerInfo,SongInfo,SongType WHERE SingerInfo.SingerId=SongInfo.SingerId AND SongType.SongTypeId=SongInfo.SongTypeId ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DBHelp.Conn);
            adapter.Fill(ds, "Info");
            DataView dv = ds.Tables["Info"].DefaultView;
            dv.RowFilter = "SongTypeName='"+SongType+"'";
            dataGridView1.DataSource = dv;
        }
        /// <summary>
        /// 双击点歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ur= dataGridView1.SelectedRows[0].Cells["SongURL"].Value.ToString();
            main.url(ur);
        }
        /// <summary>
        /// 影视金曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            SongType = "影视金曲";
            BindType();
        }
        /// <summary>
        /// 游戏动漫
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SongType = "游戏动漫";
            BindType();
        }
        /// <summary>
        /// 热门流行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SongType = "热门流行";
            BindType();
        }
        /// <summary>
        /// 经典老歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SongType = "经典老歌";
            BindType();
        }
        /// <summary>
        /// 儿歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SongType = "儿歌";
            BindType();
        }
    }      
}
