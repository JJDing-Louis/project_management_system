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
    public partial class Main : Form
    {
        private Issue Issue = new Issue();
        private Login login;
        private MySQL mySQL;
        private bool Init_Result = false;

        enum Project_Classification
        {
            Develop,
            Bug,
            Check,
        }

        string[] project_type = new string[] { "Develop", "Bug", "Check" };

        /// <summary>
        /// 使用者管理
        /// </summary>
        private UserManagement userManagement;

        public Main()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            IssueReport issueReport = new IssueReport();
            issueReport.Show();
            if (issueReport.ShowDialog() == DialogResult.OK)
            {
                //新增Issue到資料庫
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                //寫登入狀態
            }
        }

        private void btn_SingUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            if (signUp.ShowDialog() == DialogResult.OK)
            {
                //編輯動作
            }
        }

        private void btn_UserManagement_Click(object sender, EventArgs e)
        {
            if (userManagement == null)
            {
                userManagement = new UserManagement();
                userManagement.Show();
                userManagement.Disposed += new EventHandler(UserManagement_Disposed);
            }
        }

        /// <summary>
        /// 初始化專案清單
        /// </summary>
        private void Init_ProjectList()
        {
            //Issue.SearchDB_for_Project();
        }

        /// <summary>
        /// UI初始化
        /// </summary>
        /// <returns></returns>
        private void Init_UI() 
        {
            //cbo_project_type初始化
            cbo_ProjectType.DataSource = project_type;
            //cbo_project_name初始化(從資料庫抓)
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            //初始化UI
            Init_UI();
            //初始化專案清單(根據登陸的人，並顯示被分配的專案)
            Init_ProjectList();

            mySQL = new MySQL(Parameter.db_connection_string);
            mySQL.connectDB();
        }

        private void UserManagement_Disposed(object sender, EventArgs e)
        {
            userManagement = null;
        }
    }
}