using System;
using System.Collections.Generic;
using System.Data;
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
        private string db_table_view = "user_table_vt"; //需修改
        private string db_user_authority_table = "User_Authority_Table";
        private string db_user_table = "User_Table";

        /// <summary>
        /// 建構子
        /// </summary>
        public User()
        {
            db = new MySQL(Parameter.db_connection_string);
            db.connectDB();
        }

        /// <summary>
        /// 檢查使用者是否存在
        /// </summary>
        /// <param name="user_information"></param>
        /// <returns></returns>
        public bool Check_User(User user_information)
        {
            if (db.check_user_table_of_DB(db_user_table, db_column_name, user_information.account))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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
        public bool Delete_User(string account)
        {
            db.delete_user_table_of_DB(db_table_view, account);
            //需防異常做
            return true;
        }

        /// <summary>
        /// 搜尋所有使用者(待修改)
        /// </summary>
        /// <returns></returns>
        public bool Search_AllUser(out DataSet dataSet)
        {
            if (db.search_users_table_of_DB(db_table_view, out DataSet ds))
            {
                dataSet = ds;
                return true;
            }
            else
            {
                dataSet = null;
                return false;
            }
        }

        /// <summary>
        /// 搜尋使用者
        /// </summary>
        /// <returns></returns>
        public bool Search_User(User user_infromation, out User user_search_result)
        {
            if (db.search_user_table_of_DB(db_user_table, user_infromation.account, out string user_data))
            {
                user_infromation.account = user_data;
                user_infromation.name = user_data;
                user_infromation.password = user_data;
                user_infromation.authority = Convert.ToInt32(user_data);
                user_search_result = user_infromation;
                return true;
            }
            else
            {
                user_search_result = null;
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