using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKTV
{
    public partial class FrmMain : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();    //1.声明自适应类实例
        public int volume = 50;//初始音量
        bool a = true;//默认播放
        AnimateImage image;//背景动画
       
        public FrmMain()
        {
            InitializeComponent();

            #region 设置背景动态图
            image = new AnimateImage(Image.FromFile(@"C:\Users\dell\Pictures\3.gif"));
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
            image.Play();//播放动态背景
            MessageBox.Show(label5.Size.ToString());
            ptbMute1.Visible = false;
            wmpKTV.settings.volume = volume;//默认声音50
            play.Visible = false;
            label16.Text = DateTime.Now.ToString("HH:mm");//开房时间
            label17.Text = DateTime.Now.ToString("HH:mm:ss");//当前时间
            timer1.Interval = 1000;//timer间隔1000毫秒
            timer1.Enabled = true;//计时器启动
            asc.controllInitializeSize(this); //记录窗体和其控件的初始位置和大小
        }
        /// <summary>
        /// 切歌按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label9_Click(object sender, EventArgs e)
        {
            wmpKTV.URL = @"E:\KTV\Song\G.E.M.邓紫棋 - 光年之外.mkv";
        }
        /// <summary>
        /// 播放或在听按钮事件
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
        /// 歌手点歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            FrmSingerType singer = new FrmSingerType();
            singer.main = this;
            singer.ShowDialog();
            //wmpKTV.URL= "E:/Sqlserverdb/KTV/Song/" + singer.MV;
        }
        /// <summary>
        /// 单击排行榜事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label4_Click(object sender, EventArgs e)
        {
            FrmSongList list = new FrmSongList();
            list.main = this;
            list.ShowDialog();
            //wmpKTV.URL = "E:/Sqlserverdb/KTV/Song/" + list.d;

        }
        /// <summary>
        /// KTV路径
        /// </summary>
        /// <param name="c"></param>
        public void url(string c)
        {
            wmpKTV.URL = "E:/KTV/Song/" + c;
        }
        /// <summary>
        /// 字数点歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label5_Click(object sender, EventArgs e)
        {
            FrmWordCount cont = new FrmWordCount();
            cont.main = this;
            cont.ShowDialog();
        }
        /// <summary>
        /// 拼音点歌事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {
            FrmWord word = new FrmWord();
            word.main = this;
            word.ShowDialog();
        }
        /// <summary>
        /// 分类点歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {
            Type type = new Type();
            type.main = this;
            type.ShowDialog();

        }
        /// <summary>
        /// 重播事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label10_Click(object sender, EventArgs e)
        {
            wmpKTV.Ctlcontrols.stop();
            wmpKTV.Ctlcontrols.play();
        }
        /// <summary>
        /// 管理员后台
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            FrmAdmin admin = new FrmAdmin();
            admin.Show();
            admin.main = this;
        }
        /// <summary>
        /// 播放按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void play_Click(object sender, EventArgs e)
        {
            stop.Visible = true;
            play.Visible = false;
            wmpKTV.Ctlcontrols.play();//播放视频
        }
        /// <summary>
        /// 暂停按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stop_Click(object sender, EventArgs e)
        {
            play.Visible = true;
            stop.Visible = false;
            wmpKTV.Ctlcontrols.pause();//暂停视频
        }
        /// <summary>
        /// 计时器事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            label17.Text = DateTime.Now.ToString("HH:mm:ss");
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
        }
       
    }
}
