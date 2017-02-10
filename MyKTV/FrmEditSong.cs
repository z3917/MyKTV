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
    public partial class FrmEditSong : Form
    {
        public FrmEditSong()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 浏览图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "图片文件|*.bmp;*.jpg;*gif;*png";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                this.pictureBox1.ImageLocation = openFileDialog1.FileName;
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        /// <summary>
        /// 绑定歌手类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEditSong_Load(object sender, EventArgs e)
        {
            string sql = "select * from SingerInfo";

        }
    }
}
