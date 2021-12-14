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
    public partial class Main : Form
    {
        private Login login;

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
    }
}