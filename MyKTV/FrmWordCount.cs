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
    public partial class FrmWordCount : Form
    {
        public int count;//字数
        public FrmMain main;
        DataSet ds = new DataSet();
        SqlDataAdapter adapter;
        DataView dv;
        public FrmWordCount()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 返回字数页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }
        /// <summary>
        /// 退出字数点歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 单击1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel2.Location = panel1.Location;
            count = 1;
            dv.RowFilter = "SongWordCount=" + count.ToString();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmWordCount_Load(object sender, EventArgs e)
        {
            string sql = "SELECT SingerName,SongName,SongWordCount,SongURL FROM SingerInfo,SongInfo WHERE SingerInfo.SingerId=SongInfo.SingerId ";
            adapter = new SqlDataAdapter(sql, DBHelp.Conn);
            if (ds.Tables["Info"] != null)
            {
                ds.Tables["Info"].Clear();
            }
            adapter.Fill(ds, "Info");
            dv = ds.Tables["Info"].DefaultView;
            dataGridView1.DataSource = dv;
        }
        /// <summary>
        /// 单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string URL = dataGridView1.SelectedRows[0].Cells["SongURL"].Value.ToString();
            main.url(URL);
        }
        /// <summary>
        /// 单击2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel2.Location = panel1.Location;
            count = 2;
            dv.RowFilter = "SongWordCount=" + count.ToString();
        }
        /// <summary>
        /// 单击3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel2.Location = panel1.Location;
            count = 3;
            dv.RowFilter = "SongWordCount=" + count.ToString();
        }
        /// <summary>
        /// 单击4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel2.Location = panel1.Location;
            count = 4;
            dv.RowFilter = "SongWordCount=" + count.ToString();
        }
        /// <summary>
        /// 单击5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label5_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel2.Location = panel1.Location;
            count = 5;
            dv.RowFilter = "SongWordCount=" + count.ToString();
        }
        /// <summary>
        /// 单击6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label6_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel2.Location = panel1.Location;
            count = 6;
            dv.RowFilter = "SongWordCount=" + count.ToString();
        }
        /// <summary>
        /// 单击7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label7_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel2.Location = panel1.Location;
            count = 7;
            dv.RowFilter = "SongWordCount=" + count.ToString();
        }
        /// <summary>
        /// 单击8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label8_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel2.Location = panel1.Location;
            count = 8;
            dv.RowFilter = "SongWordCount=" + count.ToString();
        }
        /// <summary>
        /// 单击9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label9_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel2.Location = panel1.Location;
            count = 9;
            dv.RowFilter = "SongWordCount=" + count.ToString();
        }
        /// <summary>
        /// 单击10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label10_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel2.Location = panel1.Location;
            count = 10;
            dv.RowFilter = "SongWordCount=" + count.ToString();
        }
        /// <summary>
        /// 单击11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label11_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel2.Location = panel1.Location;
            count = 11;
            dv.RowFilter = "SongWordCount=" + count.ToString();
        }
        /// <summary>
        /// 单击12
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label12_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel2.Location = panel1.Location;
            count = 12;
            dv.RowFilter = "SongWordCount=" + count.ToString();
        }
    }
}
