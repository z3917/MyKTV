﻿using System;
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
    public partial class Type : Form
    {
        public FrmMain main;
        public string SongType;
        //给鼠标双击事件使用的值
        int avgko = 0;

        public Type()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 关闭信息窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }
        /// <summary>
        /// 戏曲事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SongType = "戏  曲";
            label2.Text = SongType;
            BindType();
        }
        /// <summary>
        /// 窗口加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Type_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// 绑定DataGridView数据
        /// </summary>
        public void BindType()
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Location = panel1.Location;
            DataSet ds = new DataSet();
            string sql = "SELECT SingerName,SongName,SongURL,SongTypeName,SongId FROM SingerInfo,SongInfo,SongType WHERE SingerInfo.SingerId=SongInfo.SingerId AND SongType.SongTypeId=SongInfo.SongTypeId ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DBHelp.Conn);
            adapter.Fill(ds, "Info");
            DataView dv = ds.Tables["Info"].DefaultView;
            dv.RowFilter = "SongTypeName='"+SongType+"'";
            dataGridView1.DataSource = dv;
        }
        /// <summary>
        /// 双击点歌
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
        /// 影视金曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            SongType = "影视金曲";
            label2.Text = SongType;
            BindType();
        }
        /// <summary>
        /// 游戏动漫
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SongType = "游戏动漫";
            label2.Text = SongType;
            BindType();
        }
        /// <summary>
        /// 热门流行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SongType = "热门流行";
            label2.Text = SongType;
            BindType();
        }
        /// <summary>
        /// 经典老歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SongType = "经典老歌";
            label2.Text = SongType;
            BindType();
        }
        /// <summary>
        /// 儿歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SongType = "儿  歌";
            label2.Text = SongType;
            BindType();
        }
      
    }      
}
