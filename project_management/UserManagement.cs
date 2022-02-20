using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase;

namespace project_management
{
    public partial class UserManagement : Form
    {
        private MySQL db;

        public UserManagement()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            UserForm signUp = new UserForm();
            signUp.Show();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            UserForm signUp = new UserForm();
            signUp.Show();
        }

        /// <summary>
        /// 載入所有使用者資訊
        /// </summary>
        private void Load_Users_Infomation()
        {
            if (db.search_users_table_of_DB(out DataSet users_dataset))
            {
                dgv_UserTable.DataSource = users_dataset;
                dgv_UserTable.DataMember = "Users_Table";
            }
            else
            {
                MessageBox.Show("查無資料!");
            }
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            db = new MySQL(Parameter.db_connection_string);
            db.connectDB();
            Load_Users_Infomation();
        }
    }
}