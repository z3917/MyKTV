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
    public partial class FrmWord : Form
    {
        public FrmMain main;
        public FrmWord()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 返回事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 查询按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string sql = "SELECT SingerName,SongN,SongName,SongURL FROM SingerInfo,SongInfo WHERE SingerInfo.SingerId=SongInfo.SingerId ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,DBHelp.Conn);
            if (ds.Tables["Info"]!=null)
            {
                ds.Tables["Info"].Clear();
            }
            adapter.Fill(ds,"Info");
            DataView dv = ds.Tables["Info"].DefaultView;
            dv.RowFilter = string.Format("SongN LIKE '%{0}%' OR SongName LIKE '%{0}%'",textBox1.Text);
            dataGridView1.DataSource = dv;

        }
        /// <summary>
        /// 双击歌曲事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            string url = dataGridView1.SelectedRows[0].Cells["SongURL"].Value.ToString();
            main.url(url);
        }
    }
}
