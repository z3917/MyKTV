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
        //给鼠标双击事件使用的值
        int avgko = 0;

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
            string sql = "Select SongName,SingerName,SongPlayCount,SongId from SongInfo,SingerInfo WHERE SongInfo.SingerId=SingerInfo.SingerId Order by SongPlayCount desc";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DBHelp.Conn);
            if (ds.Tables["Info"] != null)
            {
                ds.Tables["Info"].Clear();
            }
            adapter.Fill(ds, "Info");
            dataGridView1.DataSource = ds.Tables["Info"];
            this.Location = main.zuobiao();//本窗体的左上角坐标等于主窗体中的panel1的左上角坐标
        }
        /// <summary>
        /// 双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (avgko == PlayList.avg.Length)
            {
                MessageBox.Show("已点列表已满", "温馨提示!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            while (PlayList.avg[avgko] != 0)
            {
                avgko++;
            }
            PlayList.avg[avgko] = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["colif"].Value);
            // MessageBox.Show("添加" + Convert.ToString(dgvSingerInfo.SelectedRows[0].Cells["colif"].Value) + "歌曲成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            avgko++;
        }
        /// <summary>
        /// 窗体大小发生改变时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSongList_SizeChanged(object sender, EventArgs e)
        {
        }
    }
}
