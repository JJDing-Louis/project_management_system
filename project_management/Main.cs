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
        private bool Init_Result = false;
        private Issue Issue = new Issue();
        private Login login;
        private MySQL mySQL;
        private string[] project_type = new string[] { "Develop", "Bug", "Check" };

        /// <summary>
        /// 使用者管理
        /// </summary>
        private UserManagement userManagement;

        public Main()
        {
            InitializeComponent();
        }

        private enum Project_Classification
        {
            Develop,
            Bug,
            Check,
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

        private void btn_CreateProject_Click(object sender, EventArgs e)
        {
            ProjectForm projectForm = new ProjectForm();
            projectForm.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                //寫登入狀態
            }
        }

        private void btn_LogIn_Click_1(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            UserForm signUp = new UserForm();
            if (signUp.ShowDialog() == DialogResult.OK)
            {
                //編輯動作
            }
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            //根據選擇的DataGridView進行搜尋(Search Issue)
            //搜尋完後讀取Form，進行修改
            //呼叫IssueReportForm
            IssueReport issueReport = new IssueReport();
            issueReport.Show();
            if (issueReport.DialogResult.Equals(DialogResult.OK))
            {
                //撰寫修改報告內容
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
        }

        private void btn_Solve_Click(object sender, EventArgs e)
        {
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

        /// <summary>
        /// 釋放UserManagement表單資源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserManagement_Disposed(object sender, EventArgs e)
        {
            userManagement = null;
        }
    }
}