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
    public partial class SignUp : Form
    {
        public string account;
        public int authority;
        public string name;
        public string password;
        private string[] authority_item = new string[] { "QA", "RD", "PM" };

        /// <summary>
        /// DB搜尋條件設定
        /// </summary>
        private MySQL db;

        private string db_column_name = "Account";
        private string db_table = "user_table_vt";

        private enum authority_option
        { QA, RD, PM }

        #region UI控鍵的觸發事件

        /// <summary>
        /// 建構子初始化
        /// </summary>
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Get_information(); //寫入註冊資訊
            if (Check_Information()) //檢查註冊資訊
            {
                return;
            }
            else
            {
                Set_Information();
            }
        }

        /// <summary>
        /// 標單出現時，先進行初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUp_Shown(object sender, EventArgs e)
        {
            Authority_Initialize(); //表單初始化
        }

        #endregion UI控鍵的觸發事件

        #region 動作程序

        /// <summary>
        /// 權限清單初始化
        /// </summary>
        private void Authority_Initialize()
        {
            cbo_Authority.DataSource = authority_item;
        }

        /// <summary>
        /// 根據資料庫檢查是否有重複的帳號，有則返回True,沒有則返回false
        /// (這邊思考以一下回傳的方向)
        /// </summary>
        /// <returns></returns>
        private bool Check_Information()
        {
            if (db.searchDB(db_table, db_column_name, account))
            {
                MessageBox.Show("帳號已存在，請重新命名!");
                return true;
            }
            else
            {
                MessageBox.Show("此帳號可以使用!");
                return false;
            }
        }

        /// <summary>
        /// 取得輸入資訊
        /// </summary>
        private void Get_information()
        {
            account = txt_Account.Text;
            password = txt_Password.Text;
            name = txt_Name.Text;
            authority = cbo_Authority.SelectedIndex;
        }

        /// <summary>
        /// 將資訊寫入資料庫，並回傳結果
        /// true => 寫入成功
        /// false => 寫入失敗
        /// </summary>
        /// <returns></returns>
        private bool Set_Information()
        {
            return true;
        }
    }

    #endregion 動作程序
}