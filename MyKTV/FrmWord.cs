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
        //给鼠标双击事件使用的值
        int avgko = 0;
        AutoSizeFormClass asc = new AutoSizeFormClass();   //1.声明自适应类实例

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
        /// 双击歌曲事件
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
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmWord_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);//记录窗体和其控件的初始位置和大小
            this.Size = main.X;//本窗体的大小等于主窗体中的panel1的大小
            this.Location = main.zuobiao();//本窗体的左上角坐标等于主窗体中的panel1的左上角坐标
           
        }
        /// <summary>
        /// 窗体大小发生改变时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmWord_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }
        /// <summary>
        /// 文本更改时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button29_TextChanged(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            string sql = "SELECT SingerName,SongAB,SongName,SongURL,SongId FROM SingerInfo,SongInfo WHERE SingerInfo.SingerId=SongInfo.SingerId ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DBHelp.Conn);
            if (ds.Tables["Info"] != null)
            {
                ds.Tables["Info"].Clear();
            }
            adapter.Fill(ds, "Info");
            DataView dv = ds.Tables["Info"].DefaultView;
            dv.RowFilter = string.Format("SongAB LIKE '%{0}%' OR SongName LIKE '%{0}%'", button29.Text);
            dataGridView1.DataSource = dv;

        }
        /// <summary>
        /// 回删歌名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            button29.Text = button29.Text.Substring(0,button29.Text.Length-1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button29.Text = button29.Text+((Button)sender).Text;
        }
    
    

    }
}
