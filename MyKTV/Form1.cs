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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 歌曲信息管理单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            FrmEditSong song = new FrmEditSong();
            song.Show();
        }

        /// <summary>
        /// 歌手管理单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            FrmEditSinger edit = new FrmEditSinger();
            edit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
