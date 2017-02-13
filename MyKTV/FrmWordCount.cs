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
        AutoSizeFormClass asc = new AutoSizeFormClass();   //1.声明自适应类实例
        //给鼠标双击事件使用的值
        int avgko = 0;

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
            asc.controllInitializeSize(this);//记录窗体和其控件的初始位置和大小
            string sql = "SELECT SingerName,SongName,SongWordCount,SongURL,SongId FROM SingerInfo,SongInfo WHERE SingerInfo.SingerId=SongInfo.SingerId ";
            adapter = new SqlDataAdapter(sql, DBHelp.Conn);
            if (ds.Tables["Info"] != null)
            {
                ds.Tables["Info"].Clear();
            }
            adapter.Fill(ds, "Info");
            dv = ds.Tables["Info"].DefaultView;
            dataGridView1.DataSource = dv;
            this.Size = main.X;//本窗体的大小等于主窗体中的panel1的大小
            this.Location = main.zuobiao();//本窗体的左上角坐标等于主窗体中的panel1的左上角坐标
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
            dv.RowFilter = "SongWordCount>=" + count.ToString();
        }
        /// <summary>
        /// 窗体大小发生改变时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmWordCount_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

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
    }
}
