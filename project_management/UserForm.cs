using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_management
{
    public partial class UserForm : Form
    {
        /// <summary>
        /// 修改User旗標
        /// </summary>
        private bool modify_flag = false;

        private User user;

        private enum authority_option
        { QA, RD, PM }

        #region UI控鍵的觸發事件

        /// <summary>
        /// 建構子初始化
        /// </summary>
        public UserForm()
        {
            InitializeComponent();
            modify_flag = false;
            Init_UI_information();
        }

        /// <summary>
        /// 建構子初始化(修改User的流程)
        /// </summary>
        /// <param name="user_information"></param>
        public UserForm(User user_information)
        {
            InitializeComponent();
            modify_flag = true;
            Init_UI_information();
            Load_Information(user_information);
        }

        /// <summary>
        /// 按下OK的執行動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            ///modify_flag = true (修改資料) false(建立資料)
            if (modify_flag)
            {
                //修改使用者資料
                //取得UI資訊
                Get_information();
                //思考是否需要防出錯?
                user.Update_User(user);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                //取得UI資訊
                Get_information();
                //檢查註冊資訊
                if (Check_Information())
                {
                    //資料存在
                    return;
                }
                else
                {
                    //新增帳號資料
                    if (user.Create_User(user))
                    {
                        MessageBox.Show("使用者帳號新增成功!");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("帳號新增異常!");
                        //思考是否回傳異常!?
                    }
                }
            }
        }

        #endregion UI控鍵的觸發事件

        #region 動作程序

        /// <summary>
        /// 檢測UI帳號，寫入是否有誤，有則返回True,沒有則返回false
        /// (這邊思考以一下回傳的方向)
        /// </summary>
        /// <returns></returns>
        private bool Check_Information()
        {
            if (user.Check_User(user))
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
            user = new User();
            user.account = txt_Account.Text;
            user.password = txt_Password.Text;
            user.name = txt_Name.Text;
            user.authority = cbo_Authority.SelectedIndex;
        }

        /// <summary>
        /// 對UI內的選單資訊，進行初始化
        /// </summary>
        private void Init_UI_information()
        {
            cbo_Authority.DataSource = Enum.GetValues(typeof(authority_option)).Cast<authority_option>().ToArray();
        }

        /// <summary>
        /// 讀取要修改得使用者資訊
        /// </summary>
        /// <returns></returns>
        private bool Load_Information(User user_informaiton)
        {
            if (user_informaiton.Search_User(user_informaiton, out User search_result))
            {
                txt_Account.Text = user_informaiton.account;
                txt_Password.Text = user_informaiton.password;
                txt_Name.Text = user_informaiton.name;
                cbo_Authority.SelectedIndex = user_informaiton.authority;
                return true;
            }
            else
            {
                MessageBox.Show("使用者資料不存在或者遺失!");
                return false;
            }
        }

        #endregion 動作程序
    }
}