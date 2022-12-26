
namespace ExamPapers
{
    partial class Data
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
            this.facultyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFaculty = new System.Windows.Forms.Button();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.dtgFaculty = new System.Windows.Forms.DataGridView();
            this.departmentName = new System.Windows.Forms.TextBox();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.cmbFacultyDe = new System.Windows.Forms.ComboBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // facultyName
            // 
            this.facultyName.Location = new System.Drawing.Point(164, 24);
            this.facultyName.Name = "facultyName";
            this.facultyName.Size = new System.Drawing.Size(182, 27);
            this.facultyName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Faculty Name";
            // 
            // btnAddFaculty
            // 
            this.btnAddFaculty.Location = new System.Drawing.Point(417, 21);
            this.btnAddFaculty.Name = "btnAddFaculty";
            this.btnAddFaculty.Size = new System.Drawing.Size(94, 29);
            this.btnAddFaculty.TabIndex = 2;
            this.btnAddFaculty.Text = "Add Faculty";
            this.btnAddFaculty.UseVisualStyleBackColor = true;
            this.btnAddFaculty.Click += new System.EventHandler(this.btnAddFaculty_Click);
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(60, 226);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(151, 28);
            this.cmbFaculty.TabIndex = 3;
            // 
            // dtgFaculty
            // 
            this.dtgFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFaculty.Location = new System.Drawing.Point(60, 66);
            this.dtgFaculty.Name = "dtgFaculty";
            this.dtgFaculty.RowHeadersWidth = 51;
            this.dtgFaculty.RowTemplate.Height = 29;
            this.dtgFaculty.Size = new System.Drawing.Size(522, 123);
            this.dtgFaculty.TabIndex = 4;
            // 
            // departmentName
            // 
            this.departmentName.Location = new System.Drawing.Point(238, 227);
            this.departmentName.Name = "departmentName";
            this.departmentName.Size = new System.Drawing.Size(182, 27);
            this.departmentName.TabIndex = 5;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(462, 225);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(177, 29);
            this.btnAddDepartment.TabIndex = 6;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // cmbFacultyDe
            // 
            this.cmbFacultyDe.FormattingEnabled = true;
            this.cmbFacultyDe.Location = new System.Drawing.Point(60, 294);
            this.cmbFacultyDe.Name = "cmbFacultyDe";
            this.cmbFacultyDe.Size = new System.Drawing.Size(151, 28);
            this.cmbFacultyDe.TabIndex = 7;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(238, 294);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(151, 28);
            this.cmbDepartment.TabIndex = 8;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.cmbFacultyDe);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.departmentName);
            this.Controls.Add(this.dtgFaculty);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.btnAddFaculty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.facultyName);
            this.Name = "Data";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFaculty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox facultyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddFaculty;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.DataGridView dtgFaculty;
        private System.Windows.Forms.TextBox departmentName;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.ComboBox cmbFacultyDe;
        private System.Windows.Forms.ComboBox cmbDepartment;
    }
}