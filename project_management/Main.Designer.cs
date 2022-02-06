
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
            this.lbl_ProjectType = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_SingUp = new System.Windows.Forms.ToolStripButton();
            this.btn_SignIn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_IssueList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_SignIn,
            this.btn_SingUp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1319, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.cbo_ProjectType.Location = new System.Drawing.Point(185, 36);
            this.cbo_ProjectType.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_ProjectType.Name = "cbo_ProjectType";
            this.cbo_ProjectType.Size = new System.Drawing.Size(313, 39);
            this.cbo_ProjectType.TabIndex = 2;
            // 
            // lbl_ProjectType
            // 
            this.lbl_ProjectType.AutoSize = true;
            this.lbl_ProjectType.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProjectType.Location = new System.Drawing.Point(16, 41);
            this.lbl_ProjectType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProjectType.Name = "lbl_ProjectType";
            this.lbl_ProjectType.Size = new System.Drawing.Size(158, 32);
            this.lbl_ProjectType.TabIndex = 3;
            this.lbl_ProjectType.Text = "ProjectType";
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
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1164, 155);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Modify";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1164, 218);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1164, 280);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 48);
            this.button3.TabIndex = 7;
            this.button3.Text = "Solve";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_SingUp
            // 
            this.btn_SingUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_SingUp.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SingUp.Image = ((System.Drawing.Image)(resources.GetObject("btn_SingUp.Image")));
            this.btn_SingUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SingUp.Name = "btn_SingUp";
            this.btn_SingUp.Size = new System.Drawing.Size(96, 31);
            this.btn_SingUp.Text = "SignUp";
            this.btn_SingUp.Click += new System.EventHandler(this.btn_SingUp_Click);
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_SignIn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignIn.Image = ((System.Drawing.Image)(resources.GetObject("btn_SignIn.Image")));
            this.btn_SignIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(92, 31);
            this.btn_SignIn.Text = "Sign In";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 669);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_ProjectType);
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
        private System.Windows.Forms.Label lbl_ProjectType;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_Severity;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Authority;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Editor;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_State;
        private System.Windows.Forms.ToolStripButton btn_SignIn;
        private System.Windows.Forms.ToolStripButton btn_SingUp;
    }
}

