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
        private Login login;
        private MySQL mySQL;

        public Main()
        {
            InitializeComponent();
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

        private void Main_Shown(object sender, EventArgs e)
        {
            mySQL = new MySQL(Parameter.db_connection_string);

            mySQL.connectDB();
        }
    }
}