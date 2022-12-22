
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.searchPaperSetCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.searchSubjectName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbSearchMedium = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbSearchFaculty = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.searchRow = new System.Windows.Forms.TextBox();
            this.searchColumn = new System.Windows.Forms.TextBox();
            this.cmbSearchDepartment = new System.Windows.Forms.ComboBox();
            this.cmbSearchSide = new System.Windows.Forms.ComboBox();
            this.cmbSearchSemester = new System.Windows.Forms.ComboBox();
            this.cmbSearchYear = new System.Windows.Forms.ComboBox();
            this.searchBatchName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbSearchStatus = new System.Windows.Forms.ComboBox();
            this.searchSubjectCode = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.btnDateRange = new System.Windows.Forms.Button();
            this.preYears = new System.Windows.Forms.TextBox();
            this.btnPreYears = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.DimGray;
            this.Save.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(909, 177);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(201, 46);
            this.Save.TabIndex = 4;
            this.Save.Text = "ADD";
            this.Save.UseVisualStyleBackColor = false;
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
            this.dtDataGridView.Location = new System.Drawing.Point(29, 537);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.Update.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update.Location = new System.Drawing.Point(1116, 176);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(185, 45);
            this.Update.TabIndex = 6;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1005, 175);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(268, 27);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(80, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Paper Set Code";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(493, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subject Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(909, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Subject Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(80, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Medium";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(493, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Faculty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(909, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Department";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(80, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Semester";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // paperSetCode
            // 
            this.paperSetCode.Location = new System.Drawing.Point(169, 27);
            this.paperSetCode.Name = "paperSetCode";
            this.paperSetCode.Size = new System.Drawing.Size(123, 27);
            this.paperSetCode.TabIndex = 15;
            this.paperSetCode.TextChanged += new System.EventHandler(this.paperSetCode_TextChanged);
            // 
            // subjectCode
            // 
            this.subjectCode.Location = new System.Drawing.Point(641, 41);
            this.subjectCode.Name = "subjectCode";
            this.subjectCode.Size = new System.Drawing.Size(248, 27);
            this.subjectCode.TabIndex = 16;
            this.subjectCode.TextChanged += new System.EventHandler(this.subjectCode_TextChanged);
            // 
            // subjectName
            // 
            this.subjectName.Location = new System.Drawing.Point(1053, 41);
            this.subjectName.Name = "subjectName";
            this.subjectName.Size = new System.Drawing.Size(248, 27);
            this.subjectName.TabIndex = 17;
            this.subjectName.TextChanged += new System.EventHandler(this.subjectName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(493, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Batch Name";
            // 
            // batchName
            // 
            this.batchName.Location = new System.Drawing.Point(641, 130);
            this.batchName.Name = "batchName";
            this.batchName.Size = new System.Drawing.Size(248, 27);
            this.batchName.TabIndex = 23;
            this.batchName.TextChanged += new System.EventHandler(this.batchName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(83, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Row";
            // 
            // rowName
            // 
            this.rowName.Location = new System.Drawing.Point(123, 185);
            this.rowName.Name = "rowName";
            this.rowName.Size = new System.Drawing.Size(101, 27);
            this.rowName.TabIndex = 25;
            this.rowName.TextChanged += new System.EventHandler(this.rowName_TextChanged);
            // 
            // columnName
            // 
            this.columnName.Location = new System.Drawing.Point(298, 185);
            this.columnName.Name = "columnName";
            this.columnName.Size = new System.Drawing.Size(96, 27);
            this.columnName.TabIndex = 29;
            this.columnName.TextChanged += new System.EventHandler(this.columnName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(231, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Column";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(404, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Side";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(909, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Date";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(1053, 132);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(248, 27);
            this.date.TabIndex = 33;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // cmbMedium
            // 
            this.cmbMedium.FormattingEnabled = true;
            this.cmbMedium.Location = new System.Drawing.Point(220, 86);
            this.cmbMedium.Name = "cmbMedium";
            this.cmbMedium.Size = new System.Drawing.Size(248, 28);
            this.cmbMedium.TabIndex = 34;
            this.cmbMedium.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbfaculty
            // 
            this.cmbfaculty.FormattingEnabled = true;
            this.cmbfaculty.Location = new System.Drawing.Point(641, 86);
            this.cmbfaculty.Name = "cmbfaculty";
            this.cmbfaculty.Size = new System.Drawing.Size(248, 28);
            this.cmbfaculty.TabIndex = 35;
            this.cmbfaculty.SelectedIndexChanged += new System.EventHandler(this.cmbfaculty_SelectedIndexChanged);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(1053, 86);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(248, 28);
            this.cmbDepartment.TabIndex = 36;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(170, 129);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(109, 28);
            this.cmbSemester.TabIndex = 37;
            this.cmbSemester.SelectedIndexChanged += new System.EventHandler(this.cmbSemester_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(304, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Year";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(359, 129);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(109, 28);
            this.cmbYear.TabIndex = 39;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // cmbSide
            // 
            this.cmbSide.FormattingEnabled = true;
            this.cmbSide.Location = new System.Drawing.Point(449, 185);
            this.cmbSide.Name = "cmbSide";
            this.cmbSide.Size = new System.Drawing.Size(134, 28);
            this.cmbSide.TabIndex = 40;
            this.cmbSide.SelectedIndexChanged += new System.EventHandler(this.cmbSide_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.qty);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.paperSetCode);
            this.panel1.Location = new System.Drawing.Point(29, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 218);
            this.panel1.TabIndex = 41;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(710, 171);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(134, 28);
            this.cmbStatus.TabIndex = 68;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(560, 174);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(144, 20);
            this.label28.TabIndex = 68;
            this.label28.Text = "Available/Disposed";
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(333, 27);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(104, 27);
            this.qty.TabIndex = 69;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(298, 30);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 20);
            this.label27.TabIndex = 68;
            this.label27.Text = "Qty";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(835, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 20);
            this.label14.TabIndex = 43;
            this.label14.Text = "Search By Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(93, 268);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 20);
            this.label15.TabIndex = 45;
            this.label15.Text = "Search By Paper Set Code";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // searchPaperSetCode
            // 
            this.searchPaperSetCode.Location = new System.Drawing.Point(288, 261);
            this.searchPaperSetCode.Name = "searchPaperSetCode";
            this.searchPaperSetCode.Size = new System.Drawing.Size(268, 27);
            this.searchPaperSetCode.TabIndex = 46;
            this.searchPaperSetCode.TextChanged += new System.EventHandler(this.searchPaperSetCode_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(93, 305);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(178, 20);
            this.label16.TabIndex = 47;
            this.label16.Text = "Search By Subject Name";
            // 
            // searchSubjectName
            // 
            this.searchSubjectName.Location = new System.Drawing.Point(288, 298);
            this.searchSubjectName.Name = "searchSubjectName";
            this.searchSubjectName.Size = new System.Drawing.Size(268, 27);
            this.searchSubjectName.TabIndex = 48;
            this.searchSubjectName.TextChanged += new System.EventHandler(this.searchSubjectName_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(93, 383);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 20);
            this.label17.TabIndex = 49;
            this.label17.Text = "Search By Medium";
            // 
            // cmbSearchMedium
            // 
            this.cmbSearchMedium.FormattingEnabled = true;
            this.cmbSearchMedium.Location = new System.Drawing.Point(288, 375);
            this.cmbSearchMedium.Name = "cmbSearchMedium";
            this.cmbSearchMedium.Size = new System.Drawing.Size(268, 28);
            this.cmbSearchMedium.TabIndex = 50;
            this.cmbSearchMedium.SelectedIndexChanged += new System.EventHandler(this.cmbSearchMedium_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(93, 420);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 20);
            this.label18.TabIndex = 51;
            this.label18.Text = "Search By Faculty";
            // 
            // cmbSearchFaculty
            // 
            this.cmbSearchFaculty.FormattingEnabled = true;
            this.cmbSearchFaculty.Location = new System.Drawing.Point(288, 412);
            this.cmbSearchFaculty.Name = "cmbSearchFaculty";
            this.cmbSearchFaculty.Size = new System.Drawing.Size(268, 28);
            this.cmbSearchFaculty.TabIndex = 52;
            this.cmbSearchFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbSearchFaculty_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(863, 261);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(166, 20);
            this.label19.TabIndex = 53;
            this.label19.Text = "Search By Department";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(863, 299);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(146, 20);
            this.label20.TabIndex = 54;
            this.label20.Text = "Search By Semester";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(864, 339);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 20);
            this.label21.TabIndex = 55;
            this.label21.Text = "Search By Year";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(866, 377);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(167, 20);
            this.label22.TabIndex = 56;
            this.label22.Text = "Search By Batch Name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(539, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(112, 20);
            this.label23.TabIndex = 58;
            this.label23.Text = "Search By Row";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(539, 69);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(135, 20);
            this.label24.TabIndex = 59;
            this.label24.Text = "Search By Column";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(543, 112);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(110, 20);
            this.label25.TabIndex = 60;
            this.label25.Text = "Search By Side";
            // 
            // searchRow
            // 
            this.searchRow.Location = new System.Drawing.Point(692, 23);
            this.searchRow.Name = "searchRow";
            this.searchRow.Size = new System.Drawing.Size(135, 27);
            this.searchRow.TabIndex = 41;
            this.searchRow.TextChanged += new System.EventHandler(this.searchRow_TextChanged);
            // 
            // searchColumn
            // 
            this.searchColumn.Location = new System.Drawing.Point(691, 64);
            this.searchColumn.Name = "searchColumn";
            this.searchColumn.Size = new System.Drawing.Size(135, 27);
            this.searchColumn.TabIndex = 41;
            this.searchColumn.TextChanged += new System.EventHandler(this.searchColumn_TextChanged);
            // 
            // cmbSearchDepartment
            // 
            this.cmbSearchDepartment.FormattingEnabled = true;
            this.cmbSearchDepartment.Location = new System.Drawing.Point(1036, 256);
            this.cmbSearchDepartment.Name = "cmbSearchDepartment";
            this.cmbSearchDepartment.Size = new System.Drawing.Size(268, 28);
            this.cmbSearchDepartment.TabIndex = 61;
            this.cmbSearchDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbSearchDepartment_SelectedIndexChanged);
            // 
            // cmbSearchSide
            // 
            this.cmbSearchSide.FormattingEnabled = true;
            this.cmbSearchSide.Location = new System.Drawing.Point(692, 104);
            this.cmbSearchSide.Name = "cmbSearchSide";
            this.cmbSearchSide.Size = new System.Drawing.Size(135, 28);
            this.cmbSearchSide.TabIndex = 41;
            this.cmbSearchSide.SelectedIndexChanged += new System.EventHandler(this.cmbSearchSide_SelectedIndexChanged);
            // 
            // cmbSearchSemester
            // 
            this.cmbSearchSemester.FormattingEnabled = true;
            this.cmbSearchSemester.Location = new System.Drawing.Point(1036, 296);
            this.cmbSearchSemester.Name = "cmbSearchSemester";
            this.cmbSearchSemester.Size = new System.Drawing.Size(268, 28);
            this.cmbSearchSemester.TabIndex = 62;
            this.cmbSearchSemester.SelectedIndexChanged += new System.EventHandler(this.cmbSearchSemester_SelectedIndexChanged);
            // 
            // cmbSearchYear
            // 
            this.cmbSearchYear.FormattingEnabled = true;
            this.cmbSearchYear.Location = new System.Drawing.Point(1036, 336);
            this.cmbSearchYear.Name = "cmbSearchYear";
            this.cmbSearchYear.Size = new System.Drawing.Size(268, 28);
            this.cmbSearchYear.TabIndex = 63;
            this.cmbSearchYear.SelectedIndexChanged += new System.EventHandler(this.cmbSearchYear_SelectedIndexChanged);
            // 
            // searchBatchName
            // 
            this.searchBatchName.Location = new System.Drawing.Point(1036, 377);
            this.searchBatchName.Name = "searchBatchName";
            this.searchBatchName.Size = new System.Drawing.Size(268, 27);
            this.searchBatchName.TabIndex = 64;
            this.searchBatchName.TextChanged += new System.EventHandler(this.searchBatchName_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cmbSearchStatus);
            this.panel2.Controls.Add(this.searchSubjectCode);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.searchRow);
            this.panel2.Controls.Add(this.searchColumn);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.cmbSearchSide);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(29, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1339, 236);
            this.panel2.TabIndex = 42;
            // 
            // cmbSearchStatus
            // 
            this.cmbSearchStatus.FormattingEnabled = true;
            this.cmbSearchStatus.Location = new System.Drawing.Point(691, 151);
            this.cmbSearchStatus.Name = "cmbSearchStatus";
            this.cmbSearchStatus.Size = new System.Drawing.Size(136, 28);
            this.cmbSearchStatus.TabIndex = 70;
            // 
            // searchSubjectCode
            // 
            this.searchSubjectCode.Location = new System.Drawing.Point(257, 101);
            this.searchSubjectCode.Name = "searchSubjectCode";
            this.searchSubjectCode.Size = new System.Drawing.Size(268, 27);
            this.searchSubjectCode.TabIndex = 65;
            this.searchSubjectCode.TextChanged += new System.EventHandler(this.searchSubjectCode_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(543, 159);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(144, 20);
            this.label29.TabIndex = 71;
            this.label29.Text = "Available/Disposed";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(62, 106);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(171, 20);
            this.label26.TabIndex = 65;
            this.label26.Text = "Search By Subject Code";
            // 
            // fromDate
            // 
            this.fromDate.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDate.Location = new System.Drawing.Point(657, 491);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(248, 27);
            this.fromDate.TabIndex = 65;
            this.fromDate.ValueChanged += new System.EventHandler(this.fromDate_ValueChanged);
            // 
            // toDate
            // 
            this.toDate.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDate.Location = new System.Drawing.Point(924, 491);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(248, 27);
            this.toDate.TabIndex = 66;
            // 
            // btnDateRange
            // 
            this.btnDateRange.Location = new System.Drawing.Point(1191, 489);
            this.btnDateRange.Name = "btnDateRange";
            this.btnDateRange.Size = new System.Drawing.Size(129, 29);
            this.btnDateRange.TabIndex = 67;
            this.btnDateRange.Text = "Date Range";
            this.btnDateRange.UseVisualStyleBackColor = true;
            this.btnDateRange.Click += new System.EventHandler(this.btnDateRange_Click);
            // 
            // preYears
            // 
            this.preYears.Location = new System.Drawing.Point(376, 493);
            this.preYears.Name = "preYears";
            this.preYears.Size = new System.Drawing.Size(79, 27);
            this.preYears.TabIndex = 68;
            this.preYears.TextChanged += new System.EventHandler(this.preYears_TextChanged);
            // 
            // btnPreYears
            // 
            this.btnPreYears.Location = new System.Drawing.Point(461, 491);
            this.btnPreYears.Name = "btnPreYears";
            this.btnPreYears.Size = new System.Drawing.Size(163, 29);
            this.btnPreYears.TabIndex = 69;
            this.btnPreYears.Text = "Previous Years";
            this.btnPreYears.UseVisualStyleBackColor = true;
            this.btnPreYears.Click += new System.EventHandler(this.btnPreYears_Click);
            // 
            // Papers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1418, 760);
            this.Controls.Add(this.btnPreYears);
            this.Controls.Add(this.preYears);
            this.Controls.Add(this.btnDateRange);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.columnName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBatchName);
            this.Controls.Add(this.rowName);
            this.Controls.Add(this.cmbSearchYear);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbSearchSemester);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSide);
            this.Controls.Add(this.cmbSearchDepartment);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmbSearchFaculty);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmbSearchMedium);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.searchSubjectName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.searchPaperSetCode);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.cmbfaculty);
            this.Controls.Add(this.cmbMedium);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.batchName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.subjectName);
            this.Controls.Add(this.subjectCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Papers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Papers";
            this.Load += new System.EventHandler(this.Papers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox searchPaperSetCode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbSearchMedium;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox searchSubjectName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbSearchFaculty;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox searchBatchName;
        private System.Windows.Forms.ComboBox cmbSearchYear;
        private System.Windows.Forms.ComboBox cmbSearchSemester;
        private System.Windows.Forms.ComboBox cmbSearchSide;
        private System.Windows.Forms.ComboBox cmbSearchDepartment;
        private System.Windows.Forms.TextBox searchColumn;
        private System.Windows.Forms.TextBox searchRow;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox searchSubjectCode;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnDateRange;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmbSearchStatus;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnPreYears;
        private System.Windows.Forms.TextBox preYears;
    }
}