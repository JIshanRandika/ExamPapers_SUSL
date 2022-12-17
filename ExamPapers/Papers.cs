using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExamPapers
{
    public partial class Papers : Form
    {

        

        DataTable dt = new DataTable();

        
        string id;
        /* string subjectName;
         * string paperSetCode;
         string subjectCode;
         string medium;
         string faculty;
         string department;
         string semester;
         string year;
         string batchName;
         string date;
         string rowName;
         string columnName;
         string side;*/

        public Papers()
        {
            InitializeComponent();
            Display();
        }

        public void Clear()
        {
            paperSetCode.Text 
                = subjectCode.Text 
                = subjectName.Text 
                = cmbMedium.Text 
                = cmbfaculty.Text 
                = cmbDepartment.Text 
                = cmbSemester.Text
                = cmbYear.Text
                = batchName.Text
                = date.Text
                = rowName.Text
                = columnName.Text
                = cmbSide.Text
                = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

            

            

            Paper paper = new Paper(
                paperSetCode.Text.Trim(),
                subjectCode.Text.Trim(),
                subjectName.Text.Trim(),
                cmbMedium.Text.Trim(),
                cmbfaculty.Text.Trim(),
                cmbDepartment.Text.Trim(),
                cmbSemester.Text.Trim(),
                cmbYear.Text.Trim(),
                batchName.Text.Trim(),
                date.Text.Trim(),
                rowName.Text.Trim(),
                columnName.Text.Trim(),
                cmbSide.Text.Trim()

                );

            DbPaper.AddPaper(paper);

            Clear();
            Display();

        }

        public void Display()
        {
            /* dt.Columns.Add("PaperName");
             dt.Columns.Add("Description");

             DataRow dr = dt.NewRow();
             dr[0] = paperName;
             dr[1] = description;

             dt.Rows.Add(dr);
             dtDataGridView.DataSource = dt;*/

            DbPaper.DisplayAndSearch("SELECT ID," +
                "paperSetCode, " +
                "subjectCode, " +
                "subjectName," +
                "medium," +
                "faculty," +
                "department," +
                "semester," +
                "year," +
                "batchName," +
                "date," +
                "rowName," +
                "columnName," +
                "side" +
                " FROM paper", dtDataGridView);

        }

        private void dtDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.ColumnIndex == 0)
            {
                //Delete
                if (MessageBox.Show("Are you want to delete paper record?")==DialogResult.OK){
                    DbPaper.DeletePaper(dtDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
            }
            if (e.ColumnIndex == 1)
            {
               
                int row = e.RowIndex;
                paperSetCode.Text = Convert.ToString(dtDataGridView.Rows[e.RowIndex].Cells[3].Value);
                subjectCode.Text = Convert.ToString(dtDataGridView.Rows[e.RowIndex].Cells[4].Value);
                subjectName.Text = Convert.ToString(dtDataGridView.Rows[e.RowIndex].Cells[5].Value);
                cmbMedium.Text = Convert.ToString(dtDataGridView.Rows[e.RowIndex].Cells[6].Value);
                cmbfaculty.Text = Convert.ToString(dtDataGridView.Rows[e.RowIndex].Cells[7].Value);
                cmbDepartment.Text = Convert.ToString(dtDataGridView.Rows[e.RowIndex].Cells[8].Value);
                cmbSemester.Text = Convert.ToString(dtDataGridView.Rows[e.RowIndex].Cells[9].Value);
                cmbYear.Text = Convert.ToString(dtDataGridView.Rows[e.RowIndex].Cells[10].Value);
                batchName.Text = Convert.ToString(dtDataGridView.Rows[e.RowIndex].Cells[11].Value);
                date.Text = Convert.ToString(dtDataGridView.Rows[e.RowIndex].Cells[12].Value);
                rowName.Text = Convert.ToString(dtDataGridView.Rows[e.RowIndex].Cells[13].Value);
                columnName.Text = Convert.ToString(dtDataGridView.Rows[e.RowIndex].Cells[14].Value);
                cmbSide.Text = Convert.ToString(dtDataGridView.Rows[e.RowIndex].Cells[15].Value);
                id = Convert.ToString(dtDataGridView.Rows[e.RowIndex].Cells[2].Value);




                return;
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            Paper paper = new Paper(
                paperSetCode.Text.Trim(),
                subjectCode.Text.Trim(),
                subjectName.Text.Trim(),
                cmbMedium.Text.Trim(),
                cmbfaculty.Text.Trim(),
                cmbDepartment.Text.Trim(),
                cmbSemester.Text.Trim(),
                cmbYear.Text.Trim(),
                batchName.Text.Trim(),
                date.Text.Trim(),
                rowName.Text.Trim(),
                columnName.Text.Trim(),
                cmbSide.Text.Trim()

                );
            DbPaper.UpdatePaper(paper, id);

            Clear();
            Display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DbPaper.DisplayAndSearch("SELECT ID," +
               "paperSetCode, " +
               "subjectCode, " +
               "subjectName," +
               "medium," +
               "faculty," +
               "department," +
               "semester," +
               "year," +
               "batchName," +
               "date," +
               "rowName," +
               "columnName," +
               "side FROM paper WHERE date LIKE '%" + txtSearch.Text + "%'", dtDataGridView);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void faculty_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Papers_Load(object sender, EventArgs e)
        {
            cmbMedium.Items.Add("English");
            cmbMedium.Items.Add("Sinhala");
            cmbMedium.Items.Add("Tamil");

            cmbfaculty.Items.Add("Faculty of Applied Sciences");
            cmbfaculty.Items.Add("Faculty of Agricultural Sciences");
            cmbfaculty.Items.Add("Faculty of Geomatics");
            cmbfaculty.Items.Add("Faculty of Management Studies");
            cmbfaculty.Items.Add("Faculty of Social Sciences & Languages");
            cmbfaculty.Items.Add("Faculty of Technology");
            cmbfaculty.Items.Add("Faculty of Graduate Studies");
            cmbfaculty.Items.Add("Faculty of Medicine");

            cmbSemester.Items.Add("Semester I");
            cmbSemester.Items.Add("Semester II");

            cmbYear.Items.Add("Year 1");
            cmbYear.Items.Add("Year 2");
            cmbYear.Items.Add("Year 3");
            cmbYear.Items.Add("Year 4");

            cmbSide.Items.Add("Front");
            cmbSide.Items.Add("Back");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbPaper.DisplayAndSearch("SELECT ID," +
               "paperSetCode, " +
               "subjectCode, " +
               "subjectName," +
               "medium," +
               "faculty," +
               "department," +
               "semester," +
               "year," +
               "batchName," +
               "date," +
               "rowName," +
               "columnName," +
               "side FROM paper WHERE medium LIKE '%" + cmbMedium.Text + "%'", dtDataGridView);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbPaper.DisplayAndSearch("SELECT ID," +
               "paperSetCode, " +
               "subjectCode, " +
               "subjectName," +
               "medium," +
               "faculty," +
               "department," +
               "semester," +
               "year," +
               "batchName," +
               "date," +
               "rowName," +
               "columnName," +
               "side FROM paper WHERE department LIKE '%" + cmbDepartment.Text + "%'", dtDataGridView);
        }

        private void cmbfaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

            DbPaper.DisplayAndSearch("SELECT ID," +
               "paperSetCode, " +
               "subjectCode, " +
               "subjectName," +
               "medium," +
               "faculty," +
               "department," +
               "semester," +
               "year," +
               "batchName," +
               "date," +
               "rowName," +
               "columnName," +
               "side FROM paper WHERE faculty LIKE '%" + cmbfaculty.Text + "%'", dtDataGridView);



            if (cmbfaculty.SelectedItem == "Faculty of Applied Sciences")
            {
                cmbDepartment.Items.Clear();
                cmbDepartment.Items.Add("Department of Computing and Information System");
                cmbDepartment.Items.Add("Department of Food Sciences & Technology");
                cmbDepartment.Items.Add("Department of Natural Resources");
                cmbDepartment.Items.Add("Department of Physical Sciences And Technology");
                cmbDepartment.Items.Add("Department of Sport Sciences And Physical Education");
            }
            else if (cmbfaculty.SelectedItem == "Faculty of Agricultural Sciences")
            {
                cmbDepartment.Items.Clear();
                cmbDepartment.Items.Add("Department of Agribusiness Management");
                cmbDepartment.Items.Add("Department of Export Agriculture");
                cmbDepartment.Items.Add("Department of Livestock Production");
            }
            else if (cmbfaculty.SelectedItem == "Faculty of Geomatics")
            {
                cmbDepartment.Items.Clear();
                cmbDepartment.Items.Add("Department of Remote Sensing & GIS");
                cmbDepartment.Items.Add("Department of Surveying And Geodesy");
            }
            else if (cmbfaculty.SelectedItem == "Faculty of Management Studies")
            {
                cmbDepartment.Items.Clear();
                cmbDepartment.Items.Add("Department of Accountancy And Finance");
                cmbDepartment.Items.Add("Department of Bussiness Management");
                cmbDepartment.Items.Add("Department of Marketing Management");
                cmbDepartment.Items.Add("Department of Tourism Management");
            }
            else if (cmbfaculty.SelectedItem == "Faculty of Social Sciences & Languages")
            {
                cmbDepartment.Items.Clear();
                cmbDepartment.Items.Add("Department of Economics & Statics");
                cmbDepartment.Items.Add("Department of English Language Teaching");
                cmbDepartment.Items.Add("Department of Geography & Environmental Mangement");
                cmbDepartment.Items.Add("Department of Languages");
                cmbDepartment.Items.Add("Department of Social Sciences");
                cmbDepartment.Items.Add("Department of Information Technology");
            }
            else if (cmbfaculty.SelectedItem == "Faculty of Technology")
            {
                cmbDepartment.Items.Clear();
                cmbDepartment.Items.Add("Department of Biosystems Technology");
                cmbDepartment.Items.Add("Department of Engineering Technology");
 
            }
            else if (cmbfaculty.SelectedItem == "Faculty of Graduate Studies")
            {
                cmbDepartment.Items.Clear();
                cmbDepartment.Items.Add("Non");

            }
            else if (cmbfaculty.SelectedItem == "Faculty of Medicine")
            {
                cmbDepartment.Items.Clear();
                cmbDepartment.Items.Add("Department of Anatomy");
                cmbDepartment.Items.Add("Department of Biochemistry");
                cmbDepartment.Items.Add("Department of Community Medicine");
                cmbDepartment.Items.Add("Department of Forensic Medicine & Toxicology");
                cmbDepartment.Items.Add("Department of Medicine");
                cmbDepartment.Items.Add("Department of Mictrobiology");
                cmbDepartment.Items.Add("Department of Obstetrics And Gynaecology");
                cmbDepartment.Items.Add("Department of Paediatrics");

            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void paperSetCode_TextChanged(object sender, EventArgs e)
        {
            
            DbPaper.DisplayAndSearch("SELECT ID," +
                "paperSetCode, " +
                "subjectCode, " +
                "subjectName," +
                "medium," +
                "faculty," +
                "department," +
                "semester," +
                "year," +
                "batchName," +
                "date," +
                "rowName," +
                "columnName," +
                "side FROM paper WHERE paperSetCode LIKE '%" + paperSetCode.Text + "%'", dtDataGridView);
        }

        private void subjectCode_TextChanged(object sender, EventArgs e)
        {
            DbPaper.DisplayAndSearch("SELECT ID," +
               "paperSetCode, " +
               "subjectCode, " +
               "subjectName," +
               "medium," +
               "faculty," +
               "department," +
               "semester," +
               "year," +
               "batchName," +
               "date," +
               "rowName," +
               "columnName," +
               "side FROM paper WHERE subjectCode LIKE '%" + subjectCode.Text + "%'", dtDataGridView);
        }

        private void subjectName_TextChanged(object sender, EventArgs e)
        {
            DbPaper.DisplayAndSearch("SELECT ID," +
               "paperSetCode, " +
               "subjectCode, " +
               "subjectName," +
               "medium," +
               "faculty," +
               "department," +
               "semester," +
               "year," +
               "batchName," +
               "date," +
               "rowName," +
               "columnName," +
               "side FROM paper WHERE subjectName LIKE '%" + subjectName.Text + "%'", dtDataGridView);
        }

        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbPaper.DisplayAndSearch("SELECT ID," +
               "paperSetCode, " +
               "subjectCode, " +
               "subjectName," +
               "medium," +
               "faculty," +
               "department," +
               "semester," +
               "year," +
               "batchName," +
               "date," +
               "rowName," +
               "columnName," +
               "side FROM paper WHERE semester LIKE '%" + cmbSemester.Text + "%'", dtDataGridView);
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbPaper.DisplayAndSearch("SELECT ID," +
               "paperSetCode, " +
               "subjectCode, " +
               "subjectName," +
               "medium," +
               "faculty," +
               "department," +
               "semester," +
               "year," +
               "batchName," +
               "date," +
               "rowName," +
               "columnName," +
               "side FROM paper WHERE year LIKE '%" + cmbYear.Text + "%'", dtDataGridView);
        }

        private void batchName_TextChanged(object sender, EventArgs e)
        {
            DbPaper.DisplayAndSearch("SELECT ID," +
               "paperSetCode, " +
               "subjectCode, " +
               "subjectName," +
               "medium," +
               "faculty," +
               "department," +
               "semester," +
               "year," +
               "batchName," +
               "date," +
               "rowName," +
               "columnName," +
               "side FROM paper WHERE batchName LIKE '%" + batchName.Text + "%'", dtDataGridView);
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            DbPaper.DisplayAndSearch("SELECT ID," +
               "paperSetCode, " +
               "subjectCode, " +
               "subjectName," +
               "medium," +
               "faculty," +
               "department," +
               "semester," +
               "year," +
               "batchName," +
               "date," +
               "rowName," +
               "columnName," +
               "side FROM paper WHERE date LIKE '%" + date.Text + "%'", dtDataGridView);
        }

        private void rowName_TextChanged(object sender, EventArgs e)
        {
            DbPaper.DisplayAndSearch("SELECT ID," +
              "paperSetCode, " +
              "subjectCode, " +
              "subjectName," +
              "medium," +
              "faculty," +
              "department," +
              "semester," +
              "year," +
              "batchName," +
              "date," +
              "rowName," +
              "columnName," +
              "side FROM paper WHERE rowName LIKE '%" + rowName.Text + "%'", dtDataGridView);
        }

        private void columnName_TextChanged(object sender, EventArgs e)
        {
            DbPaper.DisplayAndSearch("SELECT ID," +
             "paperSetCode, " +
             "subjectCode, " +
             "subjectName," +
             "medium," +
             "faculty," +
             "department," +
             "semester," +
             "year," +
             "batchName," +
             "date," +
             "rowName," +
             "columnName," +
             "side FROM paper WHERE columnName LIKE '%" + columnName.Text + "%'", dtDataGridView);
        }

        private void cmbSide_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbPaper.DisplayAndSearch("SELECT ID," +
             "paperSetCode, " +
             "subjectCode, " +
             "subjectName," +
             "medium," +
             "faculty," +
             "department," +
             "semester," +
             "year," +
             "batchName," +
             "date," +
             "rowName," +
             "columnName," +
             "side FROM paper WHERE side LIKE '%" + cmbSide.Text + "%'", dtDataGridView);
        }
    }
}
