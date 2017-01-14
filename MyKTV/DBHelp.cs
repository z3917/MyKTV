using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MyKTV
{
    class DBHelp
    {
        private static string strconn = "Data Source=.;Initial Catalog=KTV;User ID=sa;Password=sa";
        //数据库连接Connection对象
        private static SqlConnection _conn;
        /// <summary>
        /// Connection对象
        /// </summary>
        public static SqlConnection Conn
        {
            get
            {
                if (_conn == null)
                {
                    _conn = new SqlConnection(strconn);
                }
                return _conn;
            }
        }
        #region 打开数据库连接
        public static void Open()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
            else if (Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();
            }
        }
        #endregion

        #region 关闭数据库连接
        public static void Close()
        {
            if (Conn.State == ConnectionState.Open || Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
            }
        }
        #endregion
    }
}
