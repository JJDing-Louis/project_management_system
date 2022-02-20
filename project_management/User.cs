using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace project_management
{
    public class User
    {
        public string account;
        public int authority;
        public string name;
        public string password;

        //使用User資訊，對資料庫進行操作
        private MySQL db;

        private string db_column_name = "Account";
        private string db_table = "user_table_vt"; //需修改

        /// <summary>
        /// 建立使用者
        /// </summary>
        /// <returns></returns>
        public bool Create_User(User user_infromation)
        {
            //建立防Bug的機制
            db.insert_user_table_of_DB(user_infromation.account, user_infromation.name, user_infromation.password, user_infromation.authority);
            return true;
        }

        /// <summary>
        /// 刪除使用者
        /// </summary>
        /// <returns></returns>
        public bool Delete_User(User user_infromation)
        {
            return true;
        }

        /// <summary>
        /// 搜尋使用者
        /// </summary>
        /// <returns></returns>
        public bool Search_User(User user_infromation)
        {
            db = new MySQL(Parameter.db_connection_string);
            db.connectDB();
            if (db.search_user_table_of_DB(db_table, db_column_name, user_infromation.account))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 修改使用者資訊
        /// </summary>
        /// <returns></returns>
        public bool Update_User(User user_infromation)
        {
            return true;
        }
    }
}