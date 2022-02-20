using System;
using System.Collections.Generic;
using System.Data;
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

        #region 資料庫連線相關

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

        #endregion 資料庫連線相關

        #region User操作相關

        /// <summary>
        /// 刪除使用者資料
        /// </summary>
        /// <param name="table_name"></param>
        /// <param name="account"></param>
        /// <returns></returns>
        public bool delete_user_table_of_DB(string table_name, string account)
        {
            string sql_cmd = $"DELETE FROM \'{table_name}\' WHERE Account = \'{account}\';";
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
            //加 NLog確認
        }

        /// <summary>
        /// 新增使用者資料(user authority改數字)
        /// </summary>
        /// <returns></returns>
        public bool insert_user_table_of_DB(string account, string name, string password, int user_authority)
        {
            string sql_cmd = $"INSERT INTO projectmanagement_db.user_table(Account,Name,Password) VALUES (\'{account}\',\'{name}\',\'{password}\');"
                + $"INSERT INTO projectmanagement_db.user_authority_table(User_Authority) VALUES (\'{user_authority}\');";
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
        /// 檢查使用者資料表的資訊
        /// </summary>
        /// <param name="tabel_name">表單名稱</param>
        /// <param name="column_name">欄位名稱</param>
        /// <param name="target">搜尋目標</param>
        /// <returns>true => 有找到, false => 沒找到</returns>
        public bool search_user_table_of_DB(string tabel_name, string column_name, string target)
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

        /// <summary>
        /// 搜尋所有使用者資料表
        /// </summary>
        /// <param name="users_table"></param>
        /// <returns></returns>
        public bool search_users_table_of_DB(out DataSet dataset)
        {
            DataSet ds = new DataSet();
            string sql_cmd = $"SELECT Account, Name, Authority FROM projectmanagement_db.user_table_vt;";
            MySqlDataAdapter db_DataAdapter = new MySqlDataAdapter(sql_cmd, connection);
            db_DataAdapter.Fill(ds, "Users_Table");
            //users_table = ds.Tables["Users_Table"];
            if (ds == null)
            {
                MessageBox.Show("使用者資料表搜尋異常!");
                dataset = null;
                return false;
            }
            else
            {
                dataset = ds;
                return true;
            }
        }

        /// <summary>
        /// 修改使用者全縣資訊
        /// </summary>
        /// <returns></returns>
        public bool update_user_table_of_DB(string table_name, string account, string name, string password, int user_authority)
        {
            string sql_cmd = $"UPDATE {table_name} SET Password = \'{password}\', Authority = \'{user_authority}\' WHERE Account = \'{account}\';";
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
            //加 NLog確認
        }

        #endregion User操作相關

        #region Issue 操作相關

        /// <summary>
        /// Issue寫入資料庫
        /// </summary>
        /// <returns></returns>
        public bool insertDB_of_Issue(string Title, string Editor, string Assign, DateTime date, DateTime duedate, int Priority, int Classification, string Content)
        {
            return true;
        }

        /// <summary>
        /// 查詢Issue
        /// </summary>
        /// <returns></returns>
        public bool searchDB_from_Issue()
        {
            return true;
        }

        #endregion Issue 操作相關
    }
}