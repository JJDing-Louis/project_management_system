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

        //取得點擊的座標
        private int select_colum_index;

        private int select_row_index;

        /// <summary>
        /// 頁面參數
        /// </summary>
        private UserForm signUp;

        private User user;

        public UserManagement()
        {
            InitializeComponent();
        }

        #region UI控鍵的觸發事件

        /// <summary>
        /// 新增使用者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            signUp = new UserForm();
            if (signUp.ShowDialog() == DialogResult.OK)
            {
                signUp.Close();
                signUp.Disposed += new EventHandler(UserForm_Disposed);
            }
            Load_Users_Infomation();
        }

        /// <summary>
        /// 刪除使用者資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            user.Delete_User(user.account);
            Load_Users_Infomation();
        }

        /// <summary>
        /// 修改使用者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modify_Click(object sender, EventArgs e)
        {
            if (select_colum_index == null || select_row_index == null)
            {
                MessageBox.Show("尚未選取任何帳號!");
                return;
            }
            signUp = new UserForm(user);
            if (signUp.ShowDialog() == DialogResult.OK)
            {
                signUp.Close();
                signUp.Disposed += new EventHandler(UserForm_Disposed);
            }
            Load_Users_Infomation();
        }

        private void dgv_UserTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //須改模組化
            get_select_information(e);

            //需加東西防異常
        }

        /// <summary>
        /// 取得選取資訊(思考是否會選到空集合)
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private void get_select_information(DataGridViewCellEventArgs e)
        {
            //取得點擊的座標
            select_colum_index = e.ColumnIndex;
            select_row_index = e.RowIndex;
            if (user == null)
            {
                user = new User();
            }
            user.account = dgv_UserTable[0, select_row_index].Value.ToString();
            user.name = dgv_UserTable[1, select_row_index].Value.ToString();
            user.authority = Convert.ToInt32(dgv_UserTable[2, select_row_index].Value);
        }

        /// <summary>
        /// UserForm的GC_Collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserForm_Disposed(object sender, EventArgs e)
        {
            signUp = null;
        }

        /// <summary>
        ///表單仔入時的執行動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserManagement_Load(object sender, EventArgs e)
        {
            db = new MySQL(Parameter.db_connection_string);
            db.connectDB();
            Load_Users_Infomation();
        }

        #endregion UI控鍵的觸發事件

        #region 動作程序

        /// <summary>
        /// 載入所有使用者資訊 (使用者權限顯示需更改)
        /// </summary>
        private void Load_Users_Infomation()
        {
            if (user == null)
            {
                user = new User();
            }
            if (user.Search_AllUser(out DataSet users_dataset))
            {
                dgv_UserTable.DataSource = users_dataset;
                dgv_UserTable.DataMember = "Users_Table";
                DataTableCollection dt = users_dataset.Tables;
            }
            else
            {
                MessageBox.Show("查無資料!");
            }
        }

        #endregion 動作程序
    }
}