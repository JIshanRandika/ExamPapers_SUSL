
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.department = new System.Windows.Forms.TextBox();
            this.semester = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.row = new System.Windows.Forms.TextBox();
            this.column = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.side = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbMedium = new System.Windows.Forms.ComboBox();
            this.cmbfaculty = new System.Windows.Forms.ComboBox();
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
            this.dtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtDataGridView.Location = new System.Drawing.Point(103, 434);
            this.dtDataGridView.Name = "dtDataGridView";
            this.dtDataGridView.RowHeadersWidth = 51;
            this.dtDataGridView.RowTemplate.Height = 29;
            this.dtDataGridView.Size = new System.Drawing.Size(679, 195);
            this.dtDataGridView.TabIndex = 5;
            this.dtDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDataGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Description";
            this.Column3.HeaderText = "Description";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column4.HeaderText = "";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Text = "Delete";
            this.Column4.UseColumnTextForButtonValue = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column5.HeaderText = "";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Text = "Edit";
            this.Column5.UseColumnTextForButtonValue = true;
            this.Column5.Width = 125;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
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
            this.txtSearch.Location = new System.Drawing.Point(559, 401);
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
            // 
            // subjectCode
            // 
            this.subjectCode.Location = new System.Drawing.Point(612, 60);
            this.subjectCode.Name = "subjectCode";
            this.subjectCode.Size = new System.Drawing.Size(248, 27);
            this.subjectCode.TabIndex = 16;
            // 
            // subjectName
            // 
            this.subjectName.Location = new System.Drawing.Point(1024, 60);
            this.subjectName.Name = "subjectName";
            this.subjectName.Size = new System.Drawing.Size(248, 27);
            this.subjectName.TabIndex = 17;
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(1024, 105);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(248, 27);
            this.department.TabIndex = 20;
            // 
            // semester
            // 
            this.semester.Location = new System.Drawing.Point(191, 149);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(248, 27);
            this.semester.TabIndex = 21;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(612, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 27);
            this.textBox1.TabIndex = 23;
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
            // row
            // 
            this.row.Location = new System.Drawing.Point(95, 234);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(135, 27);
            this.row.TabIndex = 25;
            // 
            // column
            // 
            this.column.Location = new System.Drawing.Point(368, 236);
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(135, 27);
            this.column.TabIndex = 29;
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
            // side
            // 
            this.side.Location = new System.Drawing.Point(603, 237);
            this.side.Name = "side";
            this.side.Size = new System.Drawing.Size(135, 27);
            this.side.TabIndex = 31;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1024, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 33;
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
            // 
            // Papers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 659);
            this.Controls.Add(this.cmbfaculty);
            this.Controls.Add(this.cmbMedium);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.side);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.column);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.row);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.department);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
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
        private System.Windows.Forms.TextBox semester;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox side;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox column;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox row;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMedium;
        private System.Windows.Forms.ComboBox cmbfaculty;
    }
}