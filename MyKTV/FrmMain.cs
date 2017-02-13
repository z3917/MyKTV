using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MyKTV
{
    public partial class FrmMain : Form
    {
        int avg = 0;
        AutoSizeFormClass asc = new AutoSizeFormClass();    //1.声明自适应类实例
        public int volume = 50;//初始音量
        bool a = true;//默认播放
        AnimateImage image;//背景动画
        public Size X;//放大前分组框panel1的大小

        //歌曲名数组
        string[] songName = new string[PlayList.avg.Length];
        //给数组存储歌曲名使用
        int avgnok = 0;

        //给静态ID使用
        int avgko = 0;
        int wodd = 0;

        //是否播放状态
        int b = 0;
        string womain = string.Empty;

        string[] kkoo = new string[PlayList.avg.Length];

        //已播放或未播放
        string wono = string.Empty;
        public FrmMain()
        {
            InitializeComponent();

            #region 设置背景动态图
            image = new AnimateImage(Image.FromFile(@"E:\KTV\Photo\4.gif"));
            image.OnFrameChanged += new EventHandler<EventArgs>(image_OnFrameChanged);
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            #endregion

        }
        void image_OnFrameChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出KTV点歌系统吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// 增加音量按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (volume <= 75)
            {
                volume += 25;
                wmpKTV.settings.volume = volume;
                button1.Text = volume.ToString();
            }
            else
            {
                MessageBox.Show("以达到最大音量！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (wmpKTV.settings.volume != 0)
            {
                ptbMute1.Visible = false;
                ptbMute.Visible = true;
                ptbMute1.Enabled = true;
            }
        }
        /// <summary>
        /// 减少音量按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbJian_Click(object sender, EventArgs e)
        {

            if (volume >= 25)
            {
                volume -= 25;
                wmpKTV.settings.volume = volume;
                button1.Text = volume.ToString();
            }
            else
            {
                MessageBox.Show("以达到最小音量！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (wmpKTV.settings.volume == 0)
            {
                ptbMute.Visible = false;
                ptbMute1.Location = ptbMute.Location;
                ptbMute1.Visible = true;
                ptbMute1.Enabled = false;
            }
        }
        /// <summary>
        /// 静音按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbMute_Click(object sender, EventArgs e)
        {
            if (wmpKTV.settings.volume == 0)
            {
                wmpKTV.settings.volume = volume;
                button1.Text = volume.ToString();
                ptbMute1.Visible = false;
                ptbMute.Visible = true;
            }
            else
            {
                wmpKTV.settings.volume = 0;
                button1.Text = "0";
                ptbMute.Visible = false;
                ptbMute1.Location = ptbMute.Location;
                ptbMute1.Visible = true;
            }

        }
        /// <summary>
        /// 窗口加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            wmpKTV.URL = @"E:\KTV\Song\公安部-拒绝黄赌毒视频_baofeng.avi";

            //歌曲路径
            string sql = "select ResourcePath from Resource where ResourceType='Song'";
            KTVUtil.songPath = select1(sql).ToString();

            // Thread th = new Thread(image.Play);
            //th.Start();
            //image.Play();//播放动态背景
            ptbMute1.Visible = false;
            wmpKTV.settings.volume = volume;//默认声音50
            asc.controllInitializeSize(this); //记录窗体和其控件的初始位置和大小
            this.timer1.Interval = 1000;//timer间隔1000毫秒
            this.timer1.Start();//启动timer控件

            label16.Text = DateTime.Now.ToString("HH:mm");//开房时间

            X = panel1.Size;

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
        /// 播放或暂停按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label6_Click(object sender, EventArgs e)
        {

            if (a)
            {
                wmpKTV.Ctlcontrols.pause();//暂停视频
                a = false;
            }
            else
            {
                wmpKTV.Ctlcontrols.play();//播放视频
                a = true;
            }

        }
        /// <summary>
        /// 管理员后台
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Form admin = new Form();
            admin.Show();
        }
        /// <summary>
        /// 播放按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void play_Click(object sender, EventArgs e)
        {
            if (lvwin.SelectedItems.Count > 0)
            {

                string name = lvwin.SelectedItems[0].Text;

                string sql = "select SongUrl from SongInfo where SongName='" + name + "'";
                string sql2 = "select SongUrl from songinfobo where SongName='" + name + "'";


                panel2.Visible = true;
                wmpKTV.URL = KTVUtil.songPath + "\\" + select1(sql);
                //wmpktv2.URL = KTVUtil.songPath + "\\" + word.select1(sql2);
                //wmpktv2.settings.volume = 0;

                //屏幕上方显示当前播放歌曲专用
                string sql3 = "select Songname from SongInfo where SongName='" + name + "'";
                txtName.Text = select1(sql3).ToString();


                //屏幕上方显示下一首播放歌曲专用
                int clio = PlayList.avg[1];
                if (clio != 0)
                {
                    string sql5 = "select Songname from SongInfo where SongId='" + clio + "'";
                    txtStatus.Text = select1(sql5).ToString();
                }
                else
                {
                    txtStatus.Text = "当前已是最后一首";
                }

            }
            else
            {
                MessageBox.Show("请选择一首歌后再播放！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 暂停按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stop_Click(object sender, EventArgs e)
        {

            if (avg == 0)
            {
                wmpKTV.Ctlcontrols.pause();//暂停视频
                                           // wmpktv2.Ctlcontrols.pause();
                avg = 1;
            }
            else
            {
                wmpKTV.Ctlcontrols.play();//播放视频
                                          // wmpktv2.Ctlcontrols.play();
                avg = 0;
            }
        }

        /// <summary>
        /// 窗体大小变换时的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }
        /// <summary>
        /// 窗体重绘时引发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            lock (image.Image)
            {
                e.Graphics.DrawImage(image.Image, new Point(0, 0));

            }
            label17.Text = DateTime.Now.ToString("HH:mm:ss");//当前时间


        }
        /// <summary>
        /// 重唱按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicGlee_Click(object sender, EventArgs e)
        {
            wmpKTV.Ctlcontrols.stop();
            wmpKTV.Ctlcontrols.play();
        }
        /// <summary>
        /// 切歌按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicExchange_Click(object sender, EventArgs e)
        {
            int i = 0;
            //音量到回50状态
            wmpKTV.settings.volume = 50;
            if (lvwin.SelectedItems.Count > 0 && lvwin.SelectedIndices[0] >= 0 && lvwin.SelectedIndices[0] < lvwin.Items.Count)
            {
                i = lvwin.SelectedIndices[0];
            }
            else
            {

                if (PlayList.avg[1] != 0)
                {
                    lvwin.Items.Clear();

                    for (; i < PlayList.avg.Length; i++)
                    {
                        if (PlayList.avg[i] == 0 || PlayList.avg[i + 1] == 0)
                        {
                            break;
                        }

                        PlayList.avg[i] = PlayList.avg[i + 1];

                    }
                   // PlayList.avg[i] = 0;
                    //   foreach (int item in PlayList.avg)
                    //   {
                    //       Console.WriteLine(item);
                    //   }
                    ////   shuw();

                    int k = 0;
                    while (k <= songName.Length - 1)
                    {

                        string sql = "select SongName from SongInfo where SongId='" + PlayList.avg[k] + "'";
                        songName[k] = (string)select1(sql);
                        if (songName[k] == null)
                        {
                            break;
                        }
                        ListViewItem item = new ListViewItem(songName[k]);
                        item.SubItems.AddRange(new string[] { wono });

                        //string anwo = kkoo[avgnok] = "已播放";

                        wono = "未播放";

                        lvwin.Items.Add(item);
                        k++;

                    }

                    int cli = PlayList.avg[0];


                    string sql2 = "select SongUrl from SongInfo where SongId='" + cli + "'";
                    //  string sql3 = "select SongUrl from songinfobo where SongId='" + cli + "'";

                    panel2.Visible = true;
                    wmpKTV.URL = KTVUtil.songPath + "\\" + select1(sql2);
                    //wmpktv2.URL = KTVUtil.songPath + "\\" + word.select1(sql3);
                    //wmpktv2.settings.volume = 0;

                    //屏幕上方显示当前播放歌曲专用
                    string sql4 = "select Songname from SongInfo where SongId='" + cli + "'";
                    txtName.Text = select1(sql4).ToString();


                    //屏幕下方显示当前播放歌曲专用
                    int clio = PlayList.avg[1];
                    if (clio != 0)
                    {
                        string sql5 = "select Songname from SongInfo where SongId='" + clio + "'";
                        txtStatus.Text = select1(sql5).ToString();
                    }
                    else
                    {
                        txtStatus.Text = "当前已是最后一首";
                    }

                }
                else
                {
                    MessageBox.Show("当前已是最后一首,无法进行切歌操作!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// 已点按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panel2.Size = X;//已点列表的大小
            panel2.Location = panel1.Location;//已点列表的位置
            panel2.Visible = true;

            shuw();
        }
        /// <summary>
        /// 给已点歌曲列表调用
        /// </summary>
        public void shuw()
        {
            // lvwin.Items.Clear();
            int k = 0;
            while (k <= songName.Length - 1 && avgnok <= songName.Length - 1)
            {
                string sql = "select SongName from SongInfo where SongId='" + PlayList.avg[avgnok] + "'";
                songName[avgnok] = (string)select1(sql);
                if (songName[avgnok] == null)
                {
                    break;
                }

                ListViewItem item = new ListViewItem(songName[avgnok]);

                wono = "未播放";

                item.SubItems.AddRange(new string[] { wono });

                lvwin.Items.Add(item);
                avgnok++;

                k++;
            }
        }


        /// <summary>
        /// 歌星点歌按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicSinger_Click(object sender, EventArgs e)
        {
            FrmSingerType singer = new FrmSingerType();
            singer.main = this;
            singer.Show();
        }
        /// <summary>
        /// 获取分组框的左上角坐标
        /// </summary>
        /// <returns></returns>
        public Point zuobiao()
        {
            return panel1.Location;
        }
        /// <summary>
        /// 歌曲排行按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmSongList list = new FrmSongList();
            list.main = this;
            list.Show();
        }
        /// <summary>
        /// 字数点歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicCount_Click(object sender, EventArgs e)
        {
            FrmWordCount cont = new FrmWordCount();
            cont.main = this;
            cont.ShowDialog();
        }
        /// <summary>
        /// 分类点歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Type type = new Type();
            type.main = this;
            type.Show();
        }

        /// <summary>
        /// 拼音点歌事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            FrmWord word = new FrmWord();
            word.main = this;
            word.Show();
        }
        /// <summary>
        /// 影视欣赏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 已点歌曲返回按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;

        }
    }
}
