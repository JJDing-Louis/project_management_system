
namespace project_management
{
    partial class IssueReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Editor = new System.Windows.Forms.Label();
            this.lbl_classification = new System.Windows.Forms.Label();
            this.lbl_Content = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Priority = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.cbo_Priority = new System.Windows.Forms.ComboBox();
            this.cbo_classification = new System.Windows.Forms.ComboBox();
            this.dTP_Date = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Assign = new System.Windows.Forms.Label();
            this.lbl_DueDate = new System.Windows.Forms.Label();
            this.dTP_DueDate = new System.Windows.Forms.DateTimePicker();
            this.cbo_Assign = new System.Windows.Forms.ComboBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(159, 16);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(104, 42);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Title :";
            // 
            // lbl_Editor
            // 
            this.lbl_Editor.AutoSize = true;
            this.lbl_Editor.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Editor.Location = new System.Drawing.Point(129, 62);
            this.lbl_Editor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Editor.Name = "lbl_Editor";
            this.lbl_Editor.Size = new System.Drawing.Size(134, 42);
            this.lbl_Editor.TabIndex = 1;
            this.lbl_Editor.Text = "Editor :";
            // 
            // lbl_classification
            // 
            this.lbl_classification.AutoSize = true;
            this.lbl_classification.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_classification.Location = new System.Drawing.Point(21, 292);
            this.lbl_classification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_classification.Name = "lbl_classification";
            this.lbl_classification.Size = new System.Drawing.Size(250, 42);
            this.lbl_classification.TabIndex = 2;
            this.lbl_classification.Text = "Classification :";
            // 
            // lbl_Content
            // 
            this.lbl_Content.AutoSize = true;
            this.lbl_Content.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Content.Location = new System.Drawing.Point(27, 338);
            this.lbl_Content.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Content.Name = "lbl_Content";
            this.lbl_Content.Size = new System.Drawing.Size(168, 42);
            this.lbl_Content.TabIndex = 3;
            this.lbl_Content.Text = "Content :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date :";
            // 
            // lbl_Priority
            // 
            this.lbl_Priority.AutoSize = true;
            this.lbl_Priority.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Priority.Location = new System.Drawing.Point(114, 246);
            this.lbl_Priority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Priority.Name = "lbl_Priority";
            this.lbl_Priority.Size = new System.Drawing.Size(149, 42);
            this.lbl_Priority.TabIndex = 5;
            this.lbl_Priority.Text = "Priority :";
            // 
            // txt_Title
            // 
            this.txt_Title.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title.Location = new System.Drawing.Point(267, 21);
            this.txt_Title.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(851, 38);
            this.txt_Title.TabIndex = 8;
            // 
            // cbo_Priority
            // 
            this.cbo_Priority.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Priority.FormattingEnabled = true;
            this.cbo_Priority.Items.AddRange(new object[] {
            "Administrator",
            "RD",
            "QA",
            "PM"});
            this.cbo_Priority.Location = new System.Drawing.Point(267, 251);
            this.cbo_Priority.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Priority.Name = "cbo_Priority";
            this.cbo_Priority.Size = new System.Drawing.Size(265, 39);
            this.cbo_Priority.TabIndex = 7;
            // 
            // cbo_classification
            // 
            this.cbo_classification.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_classification.FormattingEnabled = true;
            this.cbo_classification.Items.AddRange(new object[] {
            "Administrator",
            "RD",
            "QA",
            "PM"});
            this.cbo_classification.Location = new System.Drawing.Point(267, 297);
            this.cbo_classification.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_classification.Name = "cbo_classification";
            this.cbo_classification.Size = new System.Drawing.Size(265, 39);
            this.cbo_classification.TabIndex = 9;
            // 
            // dTP_Date
            // 
            this.dTP_Date.CalendarFont = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_Date.Location = new System.Drawing.Point(267, 168);
            this.dTP_Date.Margin = new System.Windows.Forms.Padding(4);
            this.dTP_Date.Name = "dTP_Date";
            this.dTP_Date.Size = new System.Drawing.Size(265, 25);
            this.dTP_Date.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 384);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1093, 369);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // btn_Report
            // 
            this.btn_Report.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.Location = new System.Drawing.Point(25, 761);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(168, 59);
            this.btn_Report.TabIndex = 13;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(202, 761);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(168, 59);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_Assign
            // 
            this.lbl_Assign.AutoSize = true;
            this.lbl_Assign.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Assign.Location = new System.Drawing.Point(115, 108);
            this.lbl_Assign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Assign.Name = "lbl_Assign";
            this.lbl_Assign.Size = new System.Drawing.Size(148, 42);
            this.lbl_Assign.TabIndex = 15;
            this.lbl_Assign.Text = "Assign :";
            // 
            // lbl_DueDate
            // 
            this.lbl_DueDate.AutoSize = true;
            this.lbl_DueDate.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DueDate.Location = new System.Drawing.Point(70, 200);
            this.lbl_DueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DueDate.Name = "lbl_DueDate";
            this.lbl_DueDate.Size = new System.Drawing.Size(193, 42);
            this.lbl_DueDate.TabIndex = 16;
            this.lbl_DueDate.Text = "Due Date :";
            // 
            // dTP_DueDate
            // 
            this.dTP_DueDate.CalendarFont = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_DueDate.Location = new System.Drawing.Point(267, 214);
            this.dTP_DueDate.Margin = new System.Windows.Forms.Padding(4);
            this.dTP_DueDate.Name = "dTP_DueDate";
            this.dTP_DueDate.Size = new System.Drawing.Size(265, 25);
            this.dTP_DueDate.TabIndex = 17;
            // 
            // cbo_Assign
            // 
            this.cbo_Assign.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Assign.FormattingEnabled = true;
            this.cbo_Assign.Location = new System.Drawing.Point(267, 112);
            this.cbo_Assign.Name = "cbo_Assign";
            this.cbo_Assign.Size = new System.Drawing.Size(192, 40);
            this.cbo_Assign.TabIndex = 18;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(265, 62);
            this.lbl_User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(74, 42);
            this.lbl_User.TabIndex = 19;
            this.lbl_User.Text = "null";
            // 
            // IssueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 834);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.cbo_Assign);
            this.Controls.Add(this.dTP_DueDate);
            this.Controls.Add(this.lbl_DueDate);
            this.Controls.Add(this.lbl_Assign);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dTP_Date);
            this.Controls.Add(this.cbo_classification);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.cbo_Priority);
            this.Controls.Add(this.lbl_Priority);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Content);
            this.Controls.Add(this.lbl_classification);
            this.Controls.Add(this.lbl_Editor);
            this.Controls.Add(this.lbl_Title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IssueReport";
            this.Text = "IssueReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Editor;
        private System.Windows.Forms.Label lbl_classification;
        private System.Windows.Forms.Label lbl_Content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Priority;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.ComboBox cbo_Priority;
        private System.Windows.Forms.ComboBox cbo_classification;
        private System.Windows.Forms.DateTimePicker dTP_Date;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Assign;
        private System.Windows.Forms.Label lbl_DueDate;
        private System.Windows.Forms.DateTimePicker dTP_DueDate;
        private System.Windows.Forms.ComboBox cbo_Assign;
        private System.Windows.Forms.Label lbl_User;
    }
}