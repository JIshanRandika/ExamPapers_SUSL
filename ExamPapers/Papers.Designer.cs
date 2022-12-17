
namespace ExamPapers
{
    partial class Papers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Save = new System.Windows.Forms.Button();
            this.dtDataGridView = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Update = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.paperSetCode = new System.Windows.Forms.TextBox();
            this.subjectCode = new System.Windows.Forms.TextBox();
            this.subjectName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.batchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rowName = new System.Windows.Forms.TextBox();
            this.columnName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cmbMedium = new System.Windows.Forms.ComboBox();
            this.cmbfaculty = new System.Windows.Forms.ComboBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbSide = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(888, 228);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(396, 29);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // dtDataGridView
            // 
            this.dtDataGridView.AllowUserToAddRows = false;
            this.dtDataGridView.AllowUserToDeleteRows = false;
            this.dtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Edit});
            this.dtDataGridView.Location = new System.Drawing.Point(29, 428);
            this.dtDataGridView.Name = "dtDataGridView";
            this.dtDataGridView.ReadOnly = true;
            this.dtDataGridView.RowHeadersWidth = 51;
            this.dtDataGridView.RowTemplate.Height = 29;
            this.dtDataGridView.Size = new System.Drawing.Size(1339, 195);
            this.dtDataGridView.TabIndex = 5;
            this.dtDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDataGridView_CellContentClick);
            // 
            // Delete
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // Edit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Edit.DefaultCellStyle = dataGridViewCellStyle2;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 125;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(888, 268);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(396, 29);
            this.Update.TabIndex = 6;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1145, 395);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(223, 27);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Paper Set Code";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subject Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(880, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Subject Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Medium";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Faculty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(880, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Department";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Semester";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // paperSetCode
            // 
            this.paperSetCode.Location = new System.Drawing.Point(191, 60);
            this.paperSetCode.Name = "paperSetCode";
            this.paperSetCode.Size = new System.Drawing.Size(248, 27);
            this.paperSetCode.TabIndex = 15;
            this.paperSetCode.TextChanged += new System.EventHandler(this.paperSetCode_TextChanged);
            // 
            // subjectCode
            // 
            this.subjectCode.Location = new System.Drawing.Point(612, 60);
            this.subjectCode.Name = "subjectCode";
            this.subjectCode.Size = new System.Drawing.Size(248, 27);
            this.subjectCode.TabIndex = 16;
            this.subjectCode.TextChanged += new System.EventHandler(this.subjectCode_TextChanged);
            // 
            // subjectName
            // 
            this.subjectName.Location = new System.Drawing.Point(1024, 60);
            this.subjectName.Name = "subjectName";
            this.subjectName.Size = new System.Drawing.Size(248, 27);
            this.subjectName.TabIndex = 17;
            this.subjectName.TextChanged += new System.EventHandler(this.subjectName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(464, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Batch Name";
            // 
            // batchName
            // 
            this.batchName.Location = new System.Drawing.Point(612, 149);
            this.batchName.Name = "batchName";
            this.batchName.Size = new System.Drawing.Size(248, 27);
            this.batchName.TabIndex = 23;
            this.batchName.TextChanged += new System.EventHandler(this.batchName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Row";
            // 
            // rowName
            // 
            this.rowName.Location = new System.Drawing.Point(95, 234);
            this.rowName.Name = "rowName";
            this.rowName.Size = new System.Drawing.Size(135, 27);
            this.rowName.TabIndex = 25;
            this.rowName.TextChanged += new System.EventHandler(this.rowName_TextChanged);
            // 
            // columnName
            // 
            this.columnName.Location = new System.Drawing.Point(368, 236);
            this.columnName.Name = "columnName";
            this.columnName.Size = new System.Drawing.Size(135, 27);
            this.columnName.TabIndex = 29;
            this.columnName.TextChanged += new System.EventHandler(this.columnName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(302, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Column";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Side";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(880, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Date";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(1024, 151);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(250, 27);
            this.date.TabIndex = 33;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // cmbMedium
            // 
            this.cmbMedium.FormattingEnabled = true;
            this.cmbMedium.Location = new System.Drawing.Point(191, 105);
            this.cmbMedium.Name = "cmbMedium";
            this.cmbMedium.Size = new System.Drawing.Size(248, 28);
            this.cmbMedium.TabIndex = 34;
            this.cmbMedium.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbfaculty
            // 
            this.cmbfaculty.FormattingEnabled = true;
            this.cmbfaculty.Location = new System.Drawing.Point(612, 105);
            this.cmbfaculty.Name = "cmbfaculty";
            this.cmbfaculty.Size = new System.Drawing.Size(248, 28);
            this.cmbfaculty.TabIndex = 35;
            this.cmbfaculty.SelectedIndexChanged += new System.EventHandler(this.cmbfaculty_SelectedIndexChanged);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(1024, 105);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(248, 28);
            this.cmbDepartment.TabIndex = 36;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(137, 151);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(109, 28);
            this.cmbSemester.TabIndex = 37;
            this.cmbSemester.SelectedIndexChanged += new System.EventHandler(this.cmbSemester_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(278, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Year";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(330, 152);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(109, 28);
            this.cmbYear.TabIndex = 39;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // cmbSide
            // 
            this.cmbSide.FormattingEnabled = true;
            this.cmbSide.Location = new System.Drawing.Point(603, 237);
            this.cmbSide.Name = "cmbSide";
            this.cmbSide.Size = new System.Drawing.Size(135, 28);
            this.cmbSide.TabIndex = 40;
            this.cmbSide.SelectedIndexChanged += new System.EventHandler(this.cmbSide_SelectedIndexChanged);
            // 
            // Papers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 659);
            this.Controls.Add(this.cmbSide);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.cmbfaculty);
            this.Controls.Add(this.cmbMedium);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.columnName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rowName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.batchName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.subjectName);
            this.Controls.Add(this.subjectCode);
            this.Controls.Add(this.paperSetCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.dtDataGridView);
            this.Controls.Add(this.Save);
            this.Name = "Papers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Papers";
            this.Load += new System.EventHandler(this.Papers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridView dtDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subjectName;
        private System.Windows.Forms.TextBox subjectCode;
        private System.Windows.Forms.TextBox paperSetCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox batchName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox columnName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox rowName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMedium;
        private System.Windows.Forms.ComboBox cmbfaculty;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbSide;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}