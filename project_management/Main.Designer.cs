
namespace project_management
{
    partial class Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_LogIn = new System.Windows.Forms.ToolStripButton();
            this.btn_Logout = new System.Windows.Forms.ToolStripButton();
            this.btn_UserManagement = new System.Windows.Forms.ToolStripButton();
            this.dGV_IssueList = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Severity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_Priority = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Authority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Editor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_State = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo_ProjectType = new System.Windows.Forms.ComboBox();
            this.lbl_Project_Type = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Solve = new System.Windows.Forms.Button();
            this.lbl_Project_Name = new System.Windows.Forms.Label();
            this.cbo_ProjectName = new System.Windows.Forms.ComboBox();
            this.btn_CreateProject = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_IssueList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_LogIn,
            this.btn_Logout,
            this.btn_UserManagement});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1314, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_LogIn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogIn.Image = ((System.Drawing.Image)(resources.GetObject("btn_LogIn.Image")));
            this.btn_LogIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(82, 31);
            this.btn_LogIn.Text = "Log in";
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click_1);
            // 
            // btn_Logout
            // 
            this.btn_Logout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Logout.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(97, 31);
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_UserManagement
            // 
            this.btn_UserManagement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_UserManagement.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UserManagement.Image = ((System.Drawing.Image)(resources.GetObject("btn_UserManagement.Image")));
            this.btn_UserManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_UserManagement.Name = "btn_UserManagement";
            this.btn_UserManagement.Size = new System.Drawing.Size(193, 31);
            this.btn_UserManagement.Text = "User Management";
            this.btn_UserManagement.Click += new System.EventHandler(this.btn_UserManagement_Click);
            // 
            // dGV_IssueList
            // 
            this.dGV_IssueList.AllowUserToAddRows = false;
            this.dGV_IssueList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_IssueList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_Severity,
            this.col_Priority,
            this.col_Date,
            this.col_Title,
            this.col_Authority,
            this.col_Editor,
            this.col_State});
            this.dGV_IssueList.Location = new System.Drawing.Point(17, 86);
            this.dGV_IssueList.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_IssueList.Name = "dGV_IssueList";
            this.dGV_IssueList.RowHeadersWidth = 51;
            this.dGV_IssueList.RowTemplate.Height = 24;
            this.dGV_IssueList.Size = new System.Drawing.Size(1129, 568);
            this.dGV_IssueList.TabIndex = 1;
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "ID";
            this.col_ID.MinimumWidth = 6;
            this.col_ID.Name = "col_ID";
            this.col_ID.Width = 40;
            // 
            // col_Severity
            // 
            this.col_Severity.HeaderText = "Severity";
            this.col_Severity.MinimumWidth = 6;
            this.col_Severity.Name = "col_Severity";
            this.col_Severity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Severity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_Severity.Width = 70;
            // 
            // col_Priority
            // 
            this.col_Priority.HeaderText = "Priority";
            this.col_Priority.MinimumWidth = 6;
            this.col_Priority.Name = "col_Priority";
            this.col_Priority.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Priority.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_Priority.Width = 70;
            // 
            // col_Date
            // 
            this.col_Date.HeaderText = "Date";
            this.col_Date.MinimumWidth = 6;
            this.col_Date.Name = "col_Date";
            this.col_Date.Width = 70;
            // 
            // col_Title
            // 
            this.col_Title.HeaderText = "Title";
            this.col_Title.MinimumWidth = 6;
            this.col_Title.Name = "col_Title";
            this.col_Title.Width = 300;
            // 
            // col_Authority
            // 
            this.col_Authority.HeaderText = "Authority";
            this.col_Authority.MinimumWidth = 6;
            this.col_Authority.Name = "col_Authority";
            this.col_Authority.Width = 70;
            // 
            // col_Editor
            // 
            this.col_Editor.HeaderText = "Editor";
            this.col_Editor.MinimumWidth = 6;
            this.col_Editor.Name = "col_Editor";
            this.col_Editor.Width = 70;
            // 
            // col_State
            // 
            this.col_State.HeaderText = "State";
            this.col_State.MinimumWidth = 6;
            this.col_State.Name = "col_State";
            this.col_State.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_State.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_State.Width = 70;
            // 
            // cbo_ProjectType
            // 
            this.cbo_ProjectType.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ProjectType.FormattingEnabled = true;
            this.cbo_ProjectType.Items.AddRange(new object[] {
            "Test Case",
            "Bug",
            "Feature Request"});
            this.cbo_ProjectType.Location = new System.Drawing.Point(198, 38);
            this.cbo_ProjectType.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_ProjectType.Name = "cbo_ProjectType";
            this.cbo_ProjectType.Size = new System.Drawing.Size(183, 39);
            this.cbo_ProjectType.TabIndex = 2;
            // 
            // lbl_Project_Type
            // 
            this.lbl_Project_Type.AutoSize = true;
            this.lbl_Project_Type.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Project_Type.Location = new System.Drawing.Point(16, 41);
            this.lbl_Project_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Project_Type.Name = "lbl_Project_Type";
            this.lbl_Project_Type.Size = new System.Drawing.Size(174, 32);
            this.lbl_Project_Type.TabIndex = 3;
            this.lbl_Project_Type.Text = "ProjectType :";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(1164, 92);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(136, 48);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modify.Location = new System.Drawing.Point(1164, 155);
            this.btn_Modify.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(136, 48);
            this.btn_Modify.TabIndex = 5;
            this.btn_Modify.Text = "Modify";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Location = new System.Drawing.Point(1164, 218);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(136, 48);
            this.btn_Remove.TabIndex = 6;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Solve
            // 
            this.btn_Solve.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Solve.Location = new System.Drawing.Point(1164, 280);
            this.btn_Solve.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Solve.Name = "btn_Solve";
            this.btn_Solve.Size = new System.Drawing.Size(136, 48);
            this.btn_Solve.TabIndex = 7;
            this.btn_Solve.Text = "Solve";
            this.btn_Solve.UseVisualStyleBackColor = true;
            this.btn_Solve.Click += new System.EventHandler(this.btn_Solve_Click);
            // 
            // lbl_Project_Name
            // 
            this.lbl_Project_Name.AutoSize = true;
            this.lbl_Project_Name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Project_Name.Location = new System.Drawing.Point(389, 41);
            this.lbl_Project_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Project_Name.Name = "lbl_Project_Name";
            this.lbl_Project_Name.Size = new System.Drawing.Size(194, 32);
            this.lbl_Project_Name.TabIndex = 8;
            this.lbl_Project_Name.Text = "Project Name :";
            // 
            // cbo_ProjectName
            // 
            this.cbo_ProjectName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ProjectName.FormattingEnabled = true;
            this.cbo_ProjectName.Items.AddRange(new object[] {
            "Test Case",
            "Bug",
            "Feature Request"});
            this.cbo_ProjectName.Location = new System.Drawing.Point(591, 38);
            this.cbo_ProjectName.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_ProjectName.Name = "cbo_ProjectName";
            this.cbo_ProjectName.Size = new System.Drawing.Size(263, 39);
            this.cbo_ProjectName.TabIndex = 9;
            // 
            // btn_CreateProject
            // 
            this.btn_CreateProject.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateProject.Location = new System.Drawing.Point(861, 38);
            this.btn_CreateProject.Name = "btn_CreateProject";
            this.btn_CreateProject.Size = new System.Drawing.Size(172, 38);
            this.btn_CreateProject.TabIndex = 10;
            this.btn_CreateProject.Text = "Create Project";
            this.btn_CreateProject.UseVisualStyleBackColor = true;
            this.btn_CreateProject.Click += new System.EventHandler(this.btn_CreateProject_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 669);
            this.Controls.Add(this.btn_CreateProject);
            this.Controls.Add(this.cbo_ProjectName);
            this.Controls.Add(this.lbl_Project_Name);
            this.Controls.Add(this.btn_Solve);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Project_Type);
            this.Controls.Add(this.cbo_ProjectType);
            this.Controls.Add(this.dGV_IssueList);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Project Management";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_IssueList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dGV_IssueList;
        private System.Windows.Forms.ComboBox cbo_ProjectType;
        private System.Windows.Forms.Label lbl_Project_Type;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Solve;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_Severity;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Authority;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Editor;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_State;
        private System.Windows.Forms.ToolStripButton btn_Logout;
        private System.Windows.Forms.ToolStripButton btn_UserManagement;
        private System.Windows.Forms.Label lbl_Project_Name;
        private System.Windows.Forms.ComboBox cbo_ProjectName;
        private System.Windows.Forms.Button btn_CreateProject;
        private System.Windows.Forms.ToolStripButton btn_LogIn;
    }
}

