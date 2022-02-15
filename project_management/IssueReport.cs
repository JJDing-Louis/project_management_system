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
    public partial class IssueReport : Form
    {
        private Issue issue;

        public IssueReport()
        {
            InitializeComponent();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
        }

        private bool InputDB()
        {
            return true;
        }

        private bool LoadIssue()
        {
            return true;
        }

        private bool ReportIssue()
        {
            issue = new Issue();
            issue.title = txt_Title.Text;
            issue.editor = lbl_Editor.Text;
            issue.assign = cbo_Assign.SelectedItem.ToString();
            issue.date = dTP_Date.Value;
            issue.duedate = dTP_DueDate.Value;
            issue.priority = cbo_Priority.SelectedIndex;
            issue.classification = cbo_classification.SelectedIndex;
            return true;
        }
    }
}