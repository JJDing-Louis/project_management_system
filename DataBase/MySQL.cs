using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataBase
{
    public class MySQL
    {
        public string connection_state;

        private MySqlConnection connection;

        /// <summary>
        /// 建構子，一開始先進行初始化
        /// </summary>
        public MySQL(string connect_string)
        {
            connection = new MySqlConnection(connect_string);
        }

        /// <summary>
        /// 連接資料庫
        /// </summary>
        public void connectDB()
        {
            MessageBox.Show("Start Connect");
            connection.Open();
            if (connection.State.ToString().Equals("Open"))
            {
                MessageBox.Show("資料庫開啟成功!");
            }
            else
            {
                MessageBox.Show("資料庫開啟失敗!");
            }
        }

        /// <summary>
        /// 新增資料
        /// </summary>
        /// <returns></returns>
        public bool insertDB()
        {
            return true;
        }

        /// <summary>
        /// 進行資料庫搜尋
        /// </summary>
        /// <param name="tabel_name">表單名稱</param>
        /// <param name="column_name">欄位名稱</param>
        /// <param name="target">搜尋目標</param>
        /// <returns>true => 有找到, false => 沒找到</returns>
        public bool searchDB(string tabel_name, string column_name, string target)
        {
            string sql = $"SELECT {column_name} From user_table_vt WHERE Account = {target}";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            string result = cmd.ExecuteScalar().ToString();
            if (result == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}