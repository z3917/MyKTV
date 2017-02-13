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
    public partial class FrmSingerType : Form
    {
        public string sex;//歌手类型
        public string type;//地区类型
        public string URL;//歌曲路径
        public FrmMain main;
        AutoSizeFormClass asc = new AutoSizeFormClass();   //1.声明自适应类实例
        //给鼠标双击事件使用的值
        int avgko = 0;

        int avg = 0;
        public FrmSingerType()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 男歌手按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sex = "男";
            panelType.Location = panelSingerType.Location;
            panelSingerType.Visible = false;
            panelType.Visible = true;
        }
        /// <summary>
        /// 女歌手按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sex = "女";
            panelType.Location = panelSingerType.Location;
            panelSingerType.Visible = false;
            panelType.Visible = true;
        }
        /// <summary>
        /// 组合按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sex = "组合";
            panelType.Location = panelSingerType.Location;
            panelSingerType.Visible = false;
            panelType.Visible = true;
        }
        /// <summary>
        /// 退出歌手点歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 返回到歌手类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            panelType.Visible = false;
            panelSingerType.Visible = true;
        }
        /// <summary>
        /// 单击韩国
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            type = "韩国";
            panelSinger.Location = panelType.Location;
            panelSinger.Visible = true;
            panelType.Visible = false;
            shu();
        }
        /// <summary>
        /// 返回到地区类别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            panelSinger.Visible = false;
            panelType.Visible = true;
        }
        /// <summary>
        /// 为listview绑定歌手
        /// </summary>
        public void shu()
        {
            try
            {
                DBHelp.Open();
                string sql = string.Format("SELECT SingerName,SingerURL FROM SingerInfo,Singertype WHERE SingerInfo.SingerTypeId=SingerType.SingerTypeId AND SingerSex='{0}' AND SingerTypeName='{1}'", sex, type);
                SqlCommand cmd = new SqlCommand(sql, DBHelp.Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int index = 0;
                if (lvdehp.Items != null)
                {
                    lvdehp.Items.Clear();
                    ilPicture.Images.Clear();
                }
                while (reader.Read())
                {
                    string name = reader["SingerName"].ToString();
                    ilPicture.Images.Add(Image.FromFile(KTVUtil.singerPhotoPath + reader["SingerURL"].ToString()));
                    ListViewItem item = new ListViewItem(name);
                    item.ImageIndex = index;
                    lvdehp.Items.Add(item);

                    index++;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK);
            }
            finally
            {
                DBHelp.Close();
            }
        }
        /// <summary>
        /// 单击华语
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            type = "华语";
            panelSinger.Location = panelType.Location;
            panelSinger.Visible = true;
            panelType.Visible = false;
            shu();
        }
        /// <summary>
        /// 单击日本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            type = "日本";
            panelSinger.Location = panelType.Location;
            panelSinger.Visible = true;
            panelType.Visible = false;
            shu();
        }
        /// <summary>
        /// 单击欧美
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            type = "欧美";
            panelSinger.Location = panelType.Location;
            panelSinger.Visible = true;
            panelType.Visible = false;
            shu();
        }
        /// <summary>
        /// 返回到歌后列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            panelSingerInfo.Visible = false;
            panelSinger.Visible = true;

        }
        /// <summary>
        /// 单击listview选项时的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvdehp_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelSinger.Visible = false;
            panelSingerInfo.Visible = true;
            panelSingerInfo.Location = panelSinger.Location;
            DataSet ds = new DataSet();
            string sql = string.Format(@"SELECT SingerName,SongName,SongURL,SongId FROM SongInfo,SingerInfo,SingerType 
                                        WHERE SongInfo.SingerId = SingerInfo.SingerId AND SingerType.SingerTypeId = SingerInfo.SingerTypeId 
                                        AND SingerSex = '{0}' AND SingerTypeName = '{1}' AND SingerName = '{2}'", sex, type, lvdehp.SelectedItems[0].Text);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DBHelp.Conn);
            if (ds.Tables["SingerInfo"] != null)
            {
                ds.Tables["SingerInfo"].Clear();
            }
            adapter.Fill(ds, "SingerInfo");
            dgvSingerInfo.DataSource = ds.Tables["SingerInfo"];
        }
        /// <summary>
        /// 用户双击播放歌曲事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSingerInfo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (avgko == PlayList.avg.Length)
            {
                MessageBox.Show("已点列表已满","温馨提示!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return;
            }
            while (PlayList.avg[avgko] != 0)
            {
                avgko++;
            }
            PlayList.avg[avgko] = Convert.ToInt32(dgvSingerInfo.SelectedRows[0].Cells["colif"].Value);
           // MessageBox.Show("添加" + Convert.ToString(dgvSingerInfo.SelectedRows[0].Cells["colif"].Value) + "歌曲成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            avgko++;
        }
        /// <summary>
        /// 窗口加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSingerType_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);//记录窗体和其控件的初始位置和大小
            this.Size = main.X;//本窗体的大小等于主窗体中的panel1的大小
            this.Location = main.zuobiao();//本窗体的左上角坐标等于主窗体中的panel1的左上角坐标
            Route();//给路径赋值
        }
        /// <summary>
        /// 给窗体加载时候赋值
        /// </summary>
        public void Route()
        {
            string sql = "select ResourcePath from Resource where ResourceType='photo'";
            //给静态歌手路径赋值
            KTVUtil.singerPhotoPath = (string)select1(sql);

            string sql2 = "select ResourcePath from Resource where ResourceType='Song'";
            //给静态歌曲路径赋值
            KTVUtil.songPath = (string)select1(sql2);
        }

        /// <summary>
        /// 返回整型
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public object select1(string sql)
        {
            object name = null;
            SqlCommand wo = new SqlCommand(sql, DBHelp.Conn);
            try
            {
                DBHelp.Open();
                name = wo.ExecuteScalar();
            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message);
            }
            finally
            {
                DBHelp.Close();
            }
            return name;
        }
        /// <summary>
        /// 窗体大小发生改变时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSingerType_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }
    }
}
