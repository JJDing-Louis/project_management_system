using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace project_management
{
    internal class Issue
    {
        public string assign;
        public int classification;
        public string content;
        public DateTime date;
        public DateTime duedate;
        public string editor;
        public string porjectname;
        public int priority;
        public int status;
        public string title;
        private MySQL mySQL;

        /// <summary>
        /// 修改Issue
        /// </summary>
        /// <returns></returns>
        public bool AlertDB()
        {
            return true;
        }

        /// <summary>
        /// 新增Issue
        /// </summary>
        /// <returns></returns>
        public bool InputDB()
        {
            mySQL = new MySQL(Parameter.db_connection_string);
            mySQL.connectDB();
            bool result = mySQL.insertDB_of_Issue(title, editor, assign, date, duedate, priority, classification, content);
            return result;
        }

        /// <summary>
        /// 查詢Issue
        /// </summary>
        /// <param name="Assign">分配人</param>
        /// <returns></returns>
        public bool SearchDB(string Assign)
        {
            return true;
        }

        /// <summary>
        /// 查詢Issue
        /// </summary>
        /// <param name="StartTime">起始時間</param>
        /// <param name="EndTime">結束時間</param>
        /// <returns></returns>
        public bool SearchDB(DateTime StartTime, DateTime EndTime)
        {
            return true;
        }

        ///新增查詢回報人，回報的問題

        public bool SearchDB_for_Project(string projectname)
        {
            return true;
        }
    }
}