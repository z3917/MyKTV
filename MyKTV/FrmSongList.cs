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
    public partial class FrmSongList : Form
    {
        public string songURL;
        public FrmMain main;
        public FrmSongList()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 退出本窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSongList_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string sql = "Select SongName,SingerName,SongPlayCount,SongURL from SongInfo,SingerInfo WHERE SongInfo.SingerId=SingerInfo.SingerId Order by SongPlayCount desc";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,DBHelp.Conn);
            if (ds.Tables["Info"]!=null)
            {
                ds.Tables["Info"].Clear();
            }
            adapter.Fill(ds,"Info");
            dataGridView1.DataSource = ds.Tables["Info"];
        }
        /// <summary>
        /// 双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            songURL = dataGridView1.SelectedRows[0].Cells["SongURL"].Value.ToString();
            main.url(songURL);
        }
    }
}
