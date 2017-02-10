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

namespace MyKTV
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DBHelp.Open();
                string sql = string.Format("SELECT COUNT(*) from Admin where LoginName=@name AND LoginPwd=@pwd");
                SqlCommand cmd = new SqlCommand(sql.ToString(), DBHelp.Conn);
                cmd.Parameters.AddWithValue("@name",textBox1.Text);
                cmd.Parameters.AddWithValue("@pwd", textBox2.Text);
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result == 1)
                {
                    Form1 form = new Form1();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("账号或密码不正确！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            finally
            {
                DBHelp.Close();
            }
        }

        /// <summary>
        /// 返回按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
