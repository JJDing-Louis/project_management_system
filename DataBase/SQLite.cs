using System;
using System.Data.SQLite;
using System.IO;

namespace DataBase
{
    public class SQLite
    {
        //欄位參數
        public static string db_folder_path = @"../Datebase";

        private string db_path = db_folder_path + @"/DB.db";

        //建立函式

        /// <summary>
        /// 建立資料庫(需確認是否可以再簡化)
        /// </summary>
        public void CreateDB()
        {
            if (!Directory.Exists(db_path))
            {
                Directory.CreateDirectory(db_path);
                using (SQLiteConnection cn = new SQLiteConnection(db_path))
                {
                    cn.Open();
                    cn.Close();
                }
            }
        }

        /// <summary>
        /// 建立Issue Tabel
        /// </summary>
        public void CreateIssueTable()
        {
            string table = "User_Table";
            using (SQLiteConnection cn = new SQLiteConnection(db_path))
            {
                //資料庫沒有連結，則開啟資料庫
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("CREATE Table Issue_Table(" +
                                                                                                           "Id Int,Severity varchar(20)," +
                                                                                                            "Priority varchar(20)," +
                                                                                                            "Date DATETIME," +
                                                                                                            "Title varchar(50)," +
                                                                                                            "Authority varchar(20)," +
                                                                                                            "Editor varchar(20))," +
                                                                                                             "State varchar(20)),", cn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        /// <summary>
        /// 建立表格函式(這個可以思考一下整合作法)
        /// </summary>
        public void CreateTable()
        {
        }

        /// <summary>
        /// 建立員工表格
        /// </summary>
        public void CreateUserTable()
        {
            string table = "User_Table";
            using (SQLiteConnection cn = new SQLiteConnection(db_path))
            {
                //資料庫沒有連結，則開啟資料庫
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("CREATE Table User_Table(" +
                                                                                                             "Authority varchar(20)," +
                                                                                                             "User_Id varchar(50)," +
                                                                                                             "Password varchar(50))",
                                                                                                             cn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        /// <summary>
        /// 刪除資料庫
        /// </summary>
        public void DeleteDB()
        {
            if (File.Exists(db_path))
            {
                File.Delete(db_path);
            }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
        }
    }
}