
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
            this.lbl_Severity = new System.Windows.Forms.Label();
            this.lbl_Content = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Priority = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(49, 16);
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
            this.lbl_Editor.Location = new System.Drawing.Point(36, 60);
            this.lbl_Editor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Editor.Name = "lbl_Editor";
            this.lbl_Editor.Size = new System.Drawing.Size(134, 42);
            this.lbl_Editor.TabIndex = 1;
            this.lbl_Editor.Text = "Editor :";
            // 
            // lbl_Severity
            // 
            this.lbl_Severity.AutoSize = true;
            this.lbl_Severity.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Severity.Location = new System.Drawing.Point(19, 191);
            this.lbl_Severity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Severity.Name = "lbl_Severity";
            this.lbl_Severity.Size = new System.Drawing.Size(166, 42);
            this.lbl_Severity.TabIndex = 2;
            this.lbl_Severity.Text = "Severity :";
            // 
            // lbl_Content
            // 
            this.lbl_Content.AutoSize = true;
            this.lbl_Content.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Content.Location = new System.Drawing.Point(19, 235);
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
            this.label1.Location = new System.Drawing.Point(45, 104);
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
            this.lbl_Priority.Location = new System.Drawing.Point(27, 148);
            this.lbl_Priority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Priority.Name = "lbl_Priority";
            this.lbl_Priority.Size = new System.Drawing.Size(149, 42);
            this.lbl_Priority.TabIndex = 5;
            this.lbl_Priority.Text = "Priority :";
            // 
            // txt_UserID
            // 
            this.txt_UserID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserID.Location = new System.Drawing.Point(204, 20);
            this.txt_UserID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(875, 38);
            this.txt_UserID.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrator",
            "RD",
            "QA",
            "PM"});
            this.comboBox1.Location = new System.Drawing.Point(204, 154);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 39);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(204, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 38);
            this.textBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Administrator",
            "RD",
            "QA",
            "PM"});
            this.comboBox2.Location = new System.Drawing.Point(204, 198);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(265, 39);
            this.comboBox2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 115);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 25);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 280);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1093, 369);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // btn_Report
            // 
            this.btn_Report.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.Location = new System.Drawing.Point(27, 657);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(168, 59);
            this.btn_Report.TabIndex = 13;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(204, 657);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(168, 59);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // IssueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 735);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txt_UserID);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_Priority);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Content);
            this.Controls.Add(this.lbl_Severity);
            this.Controls.Add(this.lbl_Editor);
            this.Controls.Add(this.lbl_Title);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IssueReport";
            this.Text = "IssueReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Editor;
        private System.Windows.Forms.Label lbl_Severity;
        private System.Windows.Forms.Label lbl_Content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Priority;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Cancel;
    }
}