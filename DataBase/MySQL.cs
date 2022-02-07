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
        public bool insertDB_of_user_data(string account, string name, string password, int user_authority)
        {
            string sql_cmd = $"INSERT INTO projectmanagement_db.user_table(Account,Name,Password) VALUES (\'{account}\',\'{name}\',\'{password}\');"
                + $"INSERT INTO projectmanagement_db.user_authority_table(User_Authority) VALUES ({user_authority});";
            MySqlCommand cmd = new MySqlCommand(sql_cmd, connection);
            int result_row = cmd.ExecuteNonQuery();
            if (result_row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //加 Nlog確認
        }

        /// <summary>
        /// 進行資料庫搜尋
        /// </summary>
        /// <param name="tabel_name">表單名稱</param>
        /// <param name="column_name">欄位名稱</param>
        /// <param name="target">搜尋目標</param>
        /// <returns>true => 有找到, false => 沒找到</returns>
        public bool searchDB_of_user_data(string tabel_name, string column_name, string target)
        {
            string sql = $"SELECT {column_name} From user_table_vt WHERE Account = \'{target}\';";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            String result = Convert.ToString(cmd.ExecuteScalar());
            if (!result.Equals(string.Empty))
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