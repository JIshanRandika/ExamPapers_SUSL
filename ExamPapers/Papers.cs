using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Data;
using System.Reflection;
using ClosedXML.Excel;

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
                = qty.Text
                = cmbStatus.Text
                = cmbDegree.Text
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
                cmbSide.Text.Trim(),
                qty.Text.Trim(),
                cmbStatus.Text.Trim(),
                cmbDegree.Text.Trim()

                );

            DbPaper.AddPaper(paper);

            Clear();
            Display();

        }

        public void fill(int row)
        {
            paperSetCode.Text = dtDataGridView.SelectedRows[row].Cells[3].Value.ToString();
            subjectCode.Text = dtDataGridView.SelectedRows[row].Cells[4].Value.ToString();
            subjectName.Text = dtDataGridView.SelectedRows[row].Cells[5].Value.ToString();
            cmbMedium.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[6].Value);
            cmbfaculty.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[7].Value);
            cmbDepartment.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[8].Value);
            cmbSemester.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[9].Value);
            cmbYear.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[10].Value);
            batchName.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[11].Value);
            date.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[12].Value);
            rowName.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[13].Value);
            columnName.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[14].Value);
            cmbSide.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[15].Value);
            qty.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[16].Value);
            cmbStatus.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[17].Value);
            cmbDegree.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[15].Value);
            id = Convert.ToString(dtDataGridView.Rows[row].Cells[2].Value);
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
                "side," +
                "qty," +
                "status," +
                "degreeName" +
                " FROM paper", dtDataGridView);

        }



        private void dtDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* int rowindex = dtDataGridView.CurrentCell.RowIndex;
            int columnindex = dtDataGridView.CurrentCell.ColumnIndex;

            paperSetCode.Text = dtDataGridView.Rows[rowindex].Cells[3].Value.ToString();*/


            if (e.ColumnIndex == 0)
            {
                //Delete
                if (MessageBox.Show("Are you want to delete paper record?","Information",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information)==DialogResult.Yes){
                    DbPaper.DeletePaper(dtDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
            }
            //Edit
            if (e.ColumnIndex == 1)
            {

                int row = e.RowIndex;
                
               

                paperSetCode.Text = dtDataGridView.Rows[row].Cells[3].Value.ToString();
                subjectCode.Text = dtDataGridView.Rows[row].Cells[4].Value.ToString();
                 subjectName.Text = dtDataGridView.Rows[row].Cells[5].Value.ToString();
                 cmbMedium.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[6].Value);
                 cmbfaculty.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[7].Value);
                 cmbDepartment.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[8].Value);
                 cmbSemester.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[9].Value);
                 cmbYear.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[10].Value);
                 batchName.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[11].Value);
                 date.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[12].Value);
                 rowName.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[13].Value);
                 columnName.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[14].Value);
                 cmbSide.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[15].Value);
                 qty.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[16].Value);
                 cmbStatus.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[17].Value);
                 cmbDegree.Text = Convert.ToString(dtDataGridView.Rows[row].Cells[18].Value);
                 id = Convert.ToString(dtDataGridView.Rows[row].Cells[2].Value);

            }
            

            }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (cmbStatus.Text.Trim()=="Available")
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
                cmbSide.Text.Trim(),
                qty.Text.Trim(),
                cmbStatus.Text.Trim(),
                cmbDegree.Text.Trim()

                );
                DbPaper.UpdatePaper(paper, id);
            }
            if (cmbStatus.Text.Trim() == "Disposed")
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
                cmbSide.Text.Trim(),
                qty.Text.Trim(),
                cmbStatus.Text.Trim()+" - "+disposedDate.Text.Trim(),
                cmbDegree.Text.Trim()

                );
                DbPaper.UpdatePaper(paper, id);
            }

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
               "side," +
               "qty," +
               "status," +
               "degreeName FROM paper WHERE date LIKE '%" + txtSearch.Text + "%'", dtDataGridView);
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

            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Disposed");

            cmbSearchStatus.Items.Add("Available");
            cmbSearchStatus.Items.Add("Disposed");

            cmbMedium.Items.Add("English");
            cmbMedium.Items.Add("Sinhala");
            cmbMedium.Items.Add("Tamil");

            cmbSearchMedium.Items.Add("English");
            cmbSearchMedium.Items.Add("Sinhala");
            cmbSearchMedium.Items.Add("Tamil");

            cmbfaculty.Items.Add("Faculty of Applied Sciences");
            cmbfaculty.Items.Add("Faculty of Agricultural Sciences");
            cmbfaculty.Items.Add("Faculty of Geomatics");
            cmbfaculty.Items.Add("Faculty of Management Studies");
            cmbfaculty.Items.Add("Faculty of Social Sciences & Languages");
            cmbfaculty.Items.Add("Faculty of Technology");
            cmbfaculty.Items.Add("Faculty of Graduate Studies");
            cmbfaculty.Items.Add("Faculty of Medicine");

            cmbSearchFaculty.Items.Add("Faculty of Applied Sciences");
            cmbSearchFaculty.Items.Add("Faculty of Agricultural Sciences");
            cmbSearchFaculty.Items.Add("Faculty of Geomatics");
            cmbSearchFaculty.Items.Add("Faculty of Management Studies");
            cmbSearchFaculty.Items.Add("Faculty of Social Sciences & Languages");
            cmbSearchFaculty.Items.Add("Faculty of Technology");
            cmbSearchFaculty.Items.Add("Faculty of Graduate Studies");
            cmbSearchFaculty.Items.Add("Faculty of Medicine");

            cmbSemester.Items.Add("Semester I");
            cmbSemester.Items.Add("Semester II");

            cmbSearchSemester.Items.Add("Semester I");
            cmbSearchSemester.Items.Add("Semester II");

            cmbYear.Items.Add("Year 1");
            cmbYear.Items.Add("Year 2");
            cmbYear.Items.Add("Year 3");
            cmbYear.Items.Add("Year 4");

            cmbSearchYear.Items.Add("Year 1");
            cmbSearchYear.Items.Add("Year 2");
            cmbSearchYear.Items.Add("Year 3");
            cmbSearchYear.Items.Add("Year 4");


            cmbSide.Items.Add("Front");
            cmbSide.Items.Add("Back");

            cmbSearchSide.Items.Add("Front");
            cmbSearchSide.Items.Add("Back");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDegree.Items.Clear();


            string query2 = "select degreeName from degree WHERE departmentName = '" + cmbDepartment.Text.ToString() + "'";
            MySql.Data.MySqlClient.MySqlConnection con = DbPaper.GetConnection();
            MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand(query2, con);

            cmd2.CommandText = query2;
            //con.Open(); 
            MySql.Data.MySqlClient.MySqlDataReader drd = cmd2.ExecuteReader();


            while (drd.Read())
            {
                cmbDegree.Items.Add(drd["degreeName"].ToString());


            }
        }

        private void cmbfaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDepartment.Items.Clear();


            string query2 = "select departmentName from department WHERE facultyName = '" + cmbfaculty.Text.ToString() + "'";
            MySql.Data.MySqlClient.MySqlConnection con = DbPaper.GetConnection();
            MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand(query2, con);

            cmd2.CommandText = query2;
            //con.Open();
            MySql.Data.MySqlClient.MySqlDataReader drd = cmd2.ExecuteReader();


            while (drd.Read())
            {
                cmbDepartment.Items.Add(drd["departmentName"].ToString());


            }



           /* if (cmbfaculty.SelectedItem == "Faculty of Applied Sciences")
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

            }*/

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void paperSetCode_TextChanged(object sender, EventArgs e)
        {
            
       
        }

        private void subjectCode_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void subjectName_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void batchName_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
           /* DbPaper.DisplayAndSearch("SELECT ID," +
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
               "side FROM paper WHERE date LIKE '%" + date.Text + "%'", dtDataGridView);*/
        }

        private void rowName_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void columnName_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbSide_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            /*foreach (DataGridViewRow row in dtDataGridView.SelectedRows)
            {
                paperSetCode.Text = row.Cells[3].Value.ToString();
                subjectCode.Text = row.Cells[4].Value.ToString();
                //...
            }
            */
            int rowindex = dtDataGridView.CurrentCell.RowIndex;
           
            
            MessageBox.Show(rowindex.ToString());

            paperSetCode.Text = dtDataGridView.Rows[rowindex].Cells[3].Value.ToString();
            MessageBox.Show(rowindex.ToString());
            subjectCode.Text = dtDataGridView.Rows[rowindex].Cells[4].Value.ToString(); 
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void searchPaperSetCode_TextChanged(object sender, EventArgs e)
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
              "side," +
               "qty," +
               "status," +
               "degreeName FROM paper WHERE paperSetCode LIKE '%" + searchPaperSetCode.Text + "%'", dtDataGridView);
        }

        private void searchSubjectCode_TextChanged(object sender, EventArgs e)
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
               "side," +
               "qty," +
               "status," +
               "degreeName FROM paper WHERE subjectCode LIKE '%" + searchSubjectCode.Text + "%'", dtDataGridView);
        }

        private void searchSubjectName_TextChanged(object sender, EventArgs e)
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
               "side," +
               "qty," +
               "status," +
               "degreeName FROM paper WHERE subjectName LIKE '%" + searchSubjectName.Text + "%'", dtDataGridView);
        }

        private void cmbSearchMedium_SelectedIndexChanged(object sender, EventArgs e)
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
               "side," +
               "qty," +
               "status," +
               "degreeName FROM paper WHERE medium LIKE '%" + cmbSearchMedium.Text + "%'", dtDataGridView);
        }

        private void cmbSearchFaculty_SelectedIndexChanged(object sender, EventArgs e)
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
               "side," +
               "qty," +
               "status," +
               "degreeName FROM paper WHERE faculty LIKE '%" + cmbSearchFaculty.Text + "%'", dtDataGridView);

            cmbSearchDepartment.Items.Clear();


            string query2 = "select departmentName from department WHERE facultyName = '" + cmbSearchFaculty.Text.ToString() + "'";
            MySql.Data.MySqlClient.MySqlConnection con = DbPaper.GetConnection();
            MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand(query2, con);

            cmd2.CommandText = query2;
            //con.Open();
            MySql.Data.MySqlClient.MySqlDataReader drd = cmd2.ExecuteReader();


            while (drd.Read())
            {
                cmbSearchDepartment.Items.Add(drd["departmentName"].ToString());


            }

           /* if (cmbSearchFaculty.SelectedItem == "Faculty of Applied Sciences")
            {
                cmbSearchDepartment.Items.Clear();
                cmbSearchDepartment.Items.Add("Department of Computing and Information System");
                cmbSearchDepartment.Items.Add("Department of Food Sciences & Technology");
                cmbSearchDepartment.Items.Add("Department of Natural Resources");
                cmbSearchDepartment.Items.Add("Department of Physical Sciences And Technology");
                cmbSearchDepartment.Items.Add("Department of Sport Sciences And Physical Education");
            }
            else if (cmbSearchFaculty.SelectedItem == "Faculty of Agricultural Sciences")
            {
                cmbSearchDepartment.Items.Clear();
                cmbSearchDepartment.Items.Add("Department of Agribusiness Management");
                cmbSearchDepartment.Items.Add("Department of Export Agriculture");
                cmbSearchDepartment.Items.Add("Department of Livestock Production");
            }
            else if (cmbSearchFaculty.SelectedItem == "Faculty of Geomatics")
            {
                cmbSearchDepartment.Items.Clear();
                cmbSearchDepartment.Items.Add("Department of Remote Sensing & GIS");
                cmbSearchDepartment.Items.Add("Department of Surveying And Geodesy");
            }
            else if (cmbSearchFaculty.SelectedItem == "Faculty of Management Studies")
            {
                cmbSearchDepartment.Items.Clear();
                cmbSearchDepartment.Items.Add("Department of Accountancy And Finance");
                cmbSearchDepartment.Items.Add("Department of Bussiness Management");
                cmbSearchDepartment.Items.Add("Department of Marketing Management");
                cmbSearchDepartment.Items.Add("Department of Tourism Management");
            }
            else if (cmbSearchFaculty.SelectedItem == "Faculty of Social Sciences & Languages")
            {
                cmbSearchDepartment.Items.Clear();
                cmbSearchDepartment.Items.Add("Department of Economics & Statics");
                cmbSearchDepartment.Items.Add("Department of English Language Teaching");
                cmbSearchDepartment.Items.Add("Department of Geography & Environmental Mangement");
                cmbSearchDepartment.Items.Add("Department of Languages");
                cmbSearchDepartment.Items.Add("Department of Social Sciences");
                cmbSearchDepartment.Items.Add("Department of Information Technology");
            }
            else if (cmbSearchFaculty.SelectedItem == "Faculty of Technology")
            {
                cmbSearchDepartment.Items.Clear();
                cmbSearchDepartment.Items.Add("Department of Biosystems Technology");
                cmbSearchDepartment.Items.Add("Department of Engineering Technology");

            }
            else if (cmbSearchFaculty.SelectedItem == "Faculty of Graduate Studies")
            {
                cmbSearchDepartment.Items.Clear();
                cmbSearchDepartment.Items.Add("Non");

            }
            else if (cmbSearchFaculty.SelectedItem == "Faculty of Medicine")
            {
                cmbSearchDepartment.Items.Clear();
                cmbSearchDepartment.Items.Add("Department of Anatomy");
                cmbSearchDepartment.Items.Add("Department of Biochemistry");
                cmbSearchDepartment.Items.Add("Department of Community Medicine");
                cmbSearchDepartment.Items.Add("Department of Forensic Medicine & Toxicology");
                cmbSearchDepartment.Items.Add("Department of Medicine");
                cmbSearchDepartment.Items.Add("Department of Mictrobiology");
                cmbSearchDepartment.Items.Add("Department of Obstetrics And Gynaecology");
                cmbSearchDepartment.Items.Add("Department of Paediatrics");

            }*/
        }

        private void cmbSearchDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSearchDegree.Items.Clear();


            string query2 = "select degreeName from degree WHERE departmentName = '" + cmbSearchDepartment.Text.ToString() + "'";
            MySql.Data.MySqlClient.MySqlConnection con = DbPaper.GetConnection();
            MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand(query2, con);

            cmd2.CommandText = query2;
            //con.Open(); 
            MySql.Data.MySqlClient.MySqlDataReader drd = cmd2.ExecuteReader();


            while (drd.Read())
            {
                cmbSearchDegree.Items.Add(drd["degreeName"].ToString());


            }

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
               "side," +
               "qty," +
               "status," +
               "degreeName FROM paper WHERE department LIKE '%" + cmbSearchDepartment.Text + "%'", dtDataGridView);


        }

        private void cmbSearchSemester_SelectedIndexChanged(object sender, EventArgs e)
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
               "side," +
               "qty," +
               "status," +
               "degreeName FROM paper WHERE semester LIKE '%" + cmbSearchSemester.Text + "%'", dtDataGridView);
        }

        private void cmbSearchYear_SelectedIndexChanged(object sender, EventArgs e)
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
               "side," +
               "qty," +
               "status," +
               "degreeName FROM paper WHERE year LIKE '%" + cmbSearchYear.Text + "%'", dtDataGridView);
        }

        private void searchBatchName_TextChanged(object sender, EventArgs e)
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
               "side," +
               "qty," +
               "status," +
               "degreeName FROM paper WHERE batchName LIKE '%" + searchBatchName.Text + "%'", dtDataGridView);
        }

        private void searchRow_TextChanged(object sender, EventArgs e)
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
              "side," +
               "qty," +
               "status," +
               "degreeName FROM paper WHERE rowName LIKE '%" + searchRow.Text + "%'", dtDataGridView);
        }

        private void searchColumn_TextChanged(object sender, EventArgs e)
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
              "side," +
               "qty," +
               "status," +
               "degreeName FROM paper WHERE columnName LIKE '%" + searchColumn.Text + "%'", dtDataGridView);
        }

        private void cmbSearchSide_SelectedIndexChanged(object sender, EventArgs e)
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
             "side," +
               "qty," +
               "status," +
               "degreeName FROM paper WHERE side LIKE '%" + cmbSearchSide.Text + "%'", dtDataGridView);
        }

        private void btnDateRange_Click(object sender, EventArgs e)
        {

            /*DateTime to = Convert.ToDateTime(toDate.Text);
            string todate = Convert.ToString(to);

            string s = "13/5/2014 12:00:00 AM";*/

            /*string date = Convert.ToString(DateTime.ParseExact(s, "yyyy-mm-dd hh:mm:ss",
                                   CultureInfo.InvariantCulture));*/

            // MessageBox.Show(fromDate.Text);



            // DateTime from = Convert.ToDateTime(fromDate.Text);
            //string fromdate = Convert.ToString(from);

            /* MessageBox.Show(fromDate.Text + " - " + toDate.Text);

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
              "side," +
                "qty," +
                "status," +
                "degreeName FROM paper WHERE date BETWEEN '" + fromDate.Text +"' AND '" + toDate.Text + "'", dtDataGridView);*/

            string query = "SELECT ID, paperSetCode, subjectCode, subjectName, medium, faculty, department, semester, year, batchName, date, rowName, columnName, side, qty, status, degreeName " +
              "FROM paper " +
              "WHERE faculty LIKE '% %'";

            if (searchPaperSetCode.Text.Length > 0)
            {
                query = query + "&& paperSetCode LIKE '%" + searchPaperSetCode.Text + "%'";

            }
            if (searchSubjectCode.Text.Length > 0)
            {
                query = query + "&& subjectCode LIKE '%" + searchSubjectCode.Text + "%'";
            }
            if (searchSubjectName.Text.Length > 0)
            {
                query = query + "&& subjectName LIKE '%" + searchSubjectName.Text + "%'";
            }
            if (cmbSearchMedium.Text.Length > 0)
            {
                query = query + "&& medium LIKE '%" + cmbSearchMedium.Text + "%'";
            }
            if (cmbSearchFaculty.Text.Length > 0)
            {
                query = query + "&& faculty LIKE '%" + cmbSearchFaculty.Text + "%'";
            }
            if (cmbSearchDepartment.Text.Length > 0)
            {
                query = query + "&& department LIKE '%" + cmbSearchDepartment.Text + "%'";
            }
            if (cmbSearchSemester.Text.Length > 0)
            {
                query = query + "&& semester LIKE '%" + cmbSearchSemester.Text + "%'";
            }
            if (cmbSearchYear.Text.Length > 0)
            {
                query = query + "&& year LIKE '%" + cmbSearchYear.Text + "%'";
            }
            if (searchBatchName.Text.Length > 0)
            {
                query = query + "&& batchName LIKE '%" + searchBatchName.Text + "%'";
            }
            if (searchBatchName.Text.Length > 0)
            {
                query = query + "&& date LIKE '%" + txtSearch.Text + "%'";
            }
            if (searchRow.Text.Length > 0)
            {
                query = query + "&& rowName LIKE '%" + searchRow.Text + "%'";
            }
            if (searchColumn.Text.Length > 0)
            {
                query = query + "&& columnName LIKE '%" + searchColumn.Text + "%'";
            }
            if (cmbSearchSide.Text.Length > 0)
            {
                query = query + "&& side LIKE '%" + cmbSearchSide.Text + "%'";
            }
            if (cmbSearchStatus.Text.Length > 0)
            {
                query = query + "&& status LIKE '%" + cmbSearchStatus.Text + "%'";
            }
            if (cmbSearchDegree.Text.Length > 0)
            {
                query = query + "&& degreeName LIKE '%" + cmbSearchDegree.Text + "%'";
            }

            
             if (fromDate.Text.Length > 0 && toDate.Text.Length > 0)
             {
                 query = query + "&& date BETWEEN '" + fromDate.Text + "' AND '" + toDate.Text + "'";
             }




            DbPaper.DisplayAndSearch(query, dtDataGridView);

        }

        private void fromDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void preYears_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPreYears_Click(object sender, EventArgs e)
        {
            string query = "SELECT ID, paperSetCode, subjectCode, subjectName, medium, faculty, department, semester, year, batchName, date, rowName, columnName, side, qty, status, degreeName " +
              "FROM paper " +
              "WHERE faculty LIKE '% %'";

            if (searchPaperSetCode.Text.Length > 0)
            {
                query = query + "&& paperSetCode LIKE '%" + searchPaperSetCode.Text + "%'";

            }
            if (searchSubjectCode.Text.Length > 0)
            {
                query = query + "&& subjectCode LIKE '%" + searchSubjectCode.Text + "%'";
            }
            if (searchSubjectName.Text.Length > 0)
            {
                query = query + "&& subjectName LIKE '%" + searchSubjectName.Text + "%'";
            }
            if (cmbSearchMedium.Text.Length > 0)
            {
                query = query + "&& medium LIKE '%" + cmbSearchMedium.Text + "%'";
            }
            if (cmbSearchFaculty.Text.Length > 0)
            {
                query = query + "&& faculty LIKE '%" + cmbSearchFaculty.Text + "%'";
            }
            if (cmbSearchDepartment.Text.Length > 0)
            {
                query = query + "&& department LIKE '%" + cmbSearchDepartment.Text + "%'";
            }
            if (cmbSearchSemester.Text.Length > 0)
            {
                query = query + "&& semester LIKE '%" + cmbSearchSemester.Text + "%'";
            }
            if (cmbSearchYear.Text.Length > 0)
            {
                query = query + "&& year LIKE '%" + cmbSearchYear.Text + "%'";
            }
            if (searchBatchName.Text.Length > 0)
            {
                query = query + "&& batchName LIKE '%" + searchBatchName.Text + "%'";
            }
            if (searchBatchName.Text.Length > 0)
            {
                query = query + "&& date LIKE '%" + txtSearch.Text + "%'";
            }
            if (searchRow.Text.Length > 0)
            {
                query = query + "&& rowName LIKE '%" + searchRow.Text + "%'";
            }
            if (searchColumn.Text.Length > 0)
            {
                query = query + "&& columnName LIKE '%" + searchColumn.Text + "%'";
            }
            if (cmbSearchSide.Text.Length > 0)
            {
                query = query + "&& side LIKE '%" + cmbSearchSide.Text + "%'";
            }
            if (cmbSearchStatus.Text.Length > 0)
            {
                query = query + "&& status LIKE '%" + cmbSearchStatus.Text + "%'";
            }
            if (cmbSearchDegree.Text.Length > 0)
            {
                query = query + "&& degreeName LIKE '%" + cmbSearchDegree.Text + "%'";
            }

            DateTime now = DateTime.Now;


            int currentYear = Convert.ToInt32(DateTime.Now.ToString("yyyy")) - Convert.ToInt32(preYears.Text);
            string currentYearString = currentYear.ToString();

            string currentDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string priviousDate = DateTime.Now.ToString(currentYearString + "-MM-dd hh:mm:ss");

            if (preYears.Text.Length > 0)
            {
                query = query + "&& date BETWEEN '" + priviousDate + "' AND '" + currentDate + "'";
            }


            /* if (fromDate.Text.Length > 0 && toDate.Text.Length > 0)
             {
                 query = query + "&& date BETWEEN '" + fromDate.Text + "' AND '" + toDate.Text + "'";
             }*/




            DbPaper.DisplayAndSearch(query, dtDataGridView);


            /*DateTime now = DateTime.Now;


            int currentYear = Convert.ToInt32(DateTime.Now.ToString("yyyy"))- Convert.ToInt32(preYears.Text);
            string currentYearString = currentYear.ToString();

            string currentDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string priviousDate = DateTime.Now.ToString(currentYearString + "-MM-dd hh:mm:ss");

            //MessageBox.Show(currentDate + priviousDate);

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
            "side," +
              "qty," +
               "status," +
               "degreeName FROM paper WHERE date BETWEEN '" + priviousDate + "' AND '" + currentDate + "'", dtDataGridView);*/
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
           
            //Creating DataTable
            DataTable dt = new DataTable();

            //Adding the Columns
            foreach (DataGridViewColumn column in dtDataGridView.Columns)
            { 
               // dt.Columns.Add(column.HeaderText, column.ValueType);
                dt.Columns.Add(column.HeaderText);
            }

            //Adding the Rows
            foreach (DataGridViewRow row in dtDataGridView.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }

            //Exporting to Excel
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            string folderPath="a";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog.SelectedPath;

            }
            //string folderPath = "C:\\Users\\ASUS\\Desktop\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "Customers");
                wb.SaveAs(folderPath + "\\DataGridViewExport.xlsx");
            }
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            Data dataWindow = new Data();
            dataWindow.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbSearchDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbPaper.DisplayAndSearch(
                "SELECT ID," +
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
               "side," +
               "qty," +
               "status," +
               "degreeName FROM paper WHERE degreeName LIKE '%" + cmbSearchDegree.Text + "%'", dtDataGridView);
        }

        private void btnDisposedAll_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to disposed all?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Paper paper = new Paper(

                 "Disposed -" + disposedAllDate.Text.Trim()

                );
                DbPaper.DisposedAll(paper, preYears.Text.Trim());
                Display();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDiposeAllRange_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to disposed all?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Paper paper = new Paper(

                 "Disposed -" + disposedAllDate.Text.Trim()

                );
                DbPaper.DisposedAllRange(paper, fromDate.Text.Trim(),toDate.Text.Trim());
                Display();
            }
        }

        private void cmbSearchStatus_SelectedIndexChanged(object sender, EventArgs e)
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
             "side," +
              "qty," +
              "status," +
              "degreeName FROM paper WHERE status LIKE '%" + cmbSearchStatus.Text + "%'", dtDataGridView);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string query = "SELECT ID, paperSetCode, subjectCode, subjectName, medium, faculty, department, semester, year, batchName, date, rowName, columnName, side, qty, status, degreeName " +
              "FROM paper " +
              "WHERE faculty LIKE '% %'";

            if (searchPaperSetCode.Text.Length > 0)
            {
                query = query + "&& paperSetCode LIKE '%" + searchPaperSetCode.Text + "%'";
               
            }
            if (searchSubjectCode.Text.Length > 0)
            {
                query = query + "&& subjectCode LIKE '%" + searchSubjectCode.Text + "%'";
            }
            if (searchSubjectName.Text.Length > 0)
            {
                query = query + "&& subjectName LIKE '%" + searchSubjectName.Text + "%'";
            }
            if (cmbSearchMedium.Text.Length > 0)
            {
                query = query + "&& medium LIKE '%" + cmbSearchMedium.Text + "%'";
            }
            if (cmbSearchFaculty.Text.Length > 0)
            {
                query = query + "&& faculty LIKE '%" + cmbSearchFaculty.Text + "%'";
            }
            if (cmbSearchDepartment.Text.Length > 0)
            {
                query = query + "&& department LIKE '%" + cmbSearchDepartment.Text + "%'";
            }
            if (cmbSearchSemester.Text.Length > 0)
            {
                query = query + "&& semester LIKE '%" + cmbSearchSemester.Text + "%'";
            }
            if (cmbSearchYear.Text.Length > 0)
            {
                query = query + "&& year LIKE '%" + cmbSearchYear.Text + "%'";
            }
            if (searchBatchName.Text.Length > 0)
            {
                query = query + "&& batchName LIKE '%" + searchBatchName.Text + "%'";
            }
            if (searchBatchName.Text.Length > 0)
            {
                query = query + "&& date LIKE '%" + txtSearch.Text + "%'";
            }
            if (searchRow.Text.Length > 0)
            {
                query = query + "&& rowName LIKE '%" + searchRow.Text + "%'";
            }
            if (searchColumn.Text.Length > 0)
            {
                query = query + "&& columnName LIKE '%" + searchColumn.Text + "%'";
            }
            if (cmbSearchSide.Text.Length > 0)
            {
                query = query + "&& side LIKE '%" + cmbSearchSide.Text + "%'";
            }
            if (cmbSearchStatus.Text.Length > 0)
            {
                query = query + "&& status LIKE '%" + cmbSearchStatus.Text + "%'";
            }
            if (cmbSearchDegree.Text.Length > 0)
            {
                query = query + "&& degreeName LIKE '%" + cmbSearchDegree.Text + "%'";
            }

            DateTime now = DateTime.Now;


            int currentYear = Convert.ToInt32(DateTime.Now.ToString("yyyy")) - Convert.ToInt32(preYears.Text);
            string currentYearString = currentYear.ToString();

            string currentDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string priviousDate = DateTime.Now.ToString(currentYearString + "-MM-dd hh:mm:ss");

            if (preYears.Text.Length > 0)
            {
                query = query + "&& date BETWEEN '" + priviousDate + "' AND '" + currentDate + "'";
            }


           /* if (fromDate.Text.Length > 0 && toDate.Text.Length > 0)
            {
                query = query + "&& date BETWEEN '" + fromDate.Text + "' AND '" + toDate.Text + "'";
            }*/




            DbPaper.DisplayAndSearch(query, dtDataGridView);
        












        /*  if (
              searchPaperSetCode.Text.Length>0 &

              searchSubjectName.Text.Length > 0 &
              searchSubjectCode.Text.Length > 0 &
              cmbSearchMedium.Text.Length > 0 &
              cmbSearchFaculty.Text.Length > 0 &

              cmbSearchDepartment.Text.Length > 0 &
              cmbSearchDegree.Text.Length > 0 &
              cmbSearchSemester.Text.Length > 0 &
              searchBatchName.Text.Length > 0 &
              txtSearch.Text.Length > 0 &

              cmbSearchYear.Text.Length > 0 &
              searchRow.Text.Length > 0 &
              searchColumn.Text.Length > 0 &
              cmbSearchSide.Text.Length > 0 &
              cmbSearchStatus.Text.Length > 0 

              )
          {
              MessageBox.Show("Okay");
          }
          else if(

              searchPaperSetCode.Text.Length > 0 &


              searchSubjectCode.Text.Length > 0 &
              cmbSearchMedium.Text.Length > 0 &
              cmbSearchFaculty.Text.Length > 0 &

              cmbSearchDepartment.Text.Length > 0 &
              cmbSearchDegree.Text.Length > 0 &
              cmbSearchSemester.Text.Length > 0 &
              searchBatchName.Text.Length > 0 &
              txtSearch.Text.Length > 0 &

              cmbSearchYear.Text.Length > 0 &
              searchRow.Text.Length > 0 &
              searchColumn.Text.Length > 0 &
              cmbSearchSide.Text.Length > 0 &
              cmbSearchStatus.Text.Length > 0

              )
          {
              MessageBox.Show("No");
          }
          else if (

              searchPaperSetCode.Text.Length > 0 &


              cmbSearchMedium.Text.Length > 0 &
              cmbSearchFaculty.Text.Length > 0 &

              cmbSearchDepartment.Text.Length > 0 &
              cmbSearchDegree.Text.Length > 0 &
              cmbSearchSemester.Text.Length > 0 &
              searchBatchName.Text.Length > 0 &
              txtSearch.Text.Length > 0 &

              cmbSearchYear.Text.Length > 0 &
              searchRow.Text.Length > 0 &
              searchColumn.Text.Length > 0 &
              cmbSearchSide.Text.Length > 0 &
              cmbSearchStatus.Text.Length > 0

              )
          {
              MessageBox.Show("No");
          }
          else if (

              searchPaperSetCode.Text.Length > 0 &


              cmbSearchFaculty.Text.Length > 0 &

              cmbSearchDepartment.Text.Length > 0 &
              cmbSearchDegree.Text.Length > 0 &
              cmbSearchSemester.Text.Length > 0 &
              searchBatchName.Text.Length > 0 &
              txtSearch.Text.Length > 0 &

              cmbSearchYear.Text.Length > 0 &
              searchRow.Text.Length > 0 &
              searchColumn.Text.Length > 0 &
              cmbSearchSide.Text.Length > 0 &
              cmbSearchStatus.Text.Length > 0

              )
          {
              MessageBox.Show("No");
          }
          else if (

              searchPaperSetCode.Text.Length > 0 &


              cmbSearchDepartment.Text.Length > 0 &
              cmbSearchDegree.Text.Length > 0 &
              cmbSearchSemester.Text.Length > 0 &
              searchBatchName.Text.Length > 0 &
              txtSearch.Text.Length > 0 &

              cmbSearchYear.Text.Length > 0 &
              searchRow.Text.Length > 0 &
              searchColumn.Text.Length > 0 &
              cmbSearchSide.Text.Length > 0 &
              cmbSearchStatus.Text.Length > 0
              )
          {
              MessageBox.Show("No");
          }
          else if (

              searchPaperSetCode.Text.Length > 0 &


              cmbSearchDegree.Text.Length > 0 &
              cmbSearchSemester.Text.Length > 0 &
              searchBatchName.Text.Length > 0 &
              txtSearch.Text.Length > 0 &

              cmbSearchYear.Text.Length > 0 &
              searchRow.Text.Length > 0 &
              searchColumn.Text.Length > 0 &
              cmbSearchSide.Text.Length > 0 &
              cmbSearchStatus.Text.Length > 0
              )
          {
              MessageBox.Show("No");
          }
          else if (

              searchPaperSetCode.Text.Length > 0 &


              cmbSearchSemester.Text.Length > 0 &
              searchBatchName.Text.Length > 0 &
              txtSearch.Text.Length > 0 &

              cmbSearchYear.Text.Length > 0 &
              searchRow.Text.Length > 0 &
              searchColumn.Text.Length > 0 &
              cmbSearchSide.Text.Length > 0 &
              cmbSearchStatus.Text.Length > 0
              )
          {
              MessageBox.Show("No");
          }
          else if (

              searchPaperSetCode.Text.Length > 0 &


              searchBatchName.Text.Length > 0 &
              txtSearch.Text.Length > 0 &

              cmbSearchYear.Text.Length > 0 &
              searchRow.Text.Length > 0 &
              searchColumn.Text.Length > 0 &
              cmbSearchSide.Text.Length > 0 &
              cmbSearchStatus.Text.Length > 0
              )
          {
              MessageBox.Show("No");
          }
          else if (

              searchPaperSetCode.Text.Length > 0 &


              txtSearch.Text.Length > 0 &

              cmbSearchYear.Text.Length > 0 &
              searchRow.Text.Length > 0 &
              searchColumn.Text.Length > 0 &
              cmbSearchSide.Text.Length > 0 &
              cmbSearchStatus.Text.Length > 0
              )
          {
              MessageBox.Show("No");
          }

          else if (

              searchPaperSetCode.Text.Length > 0 &


              cmbSearchYear.Text.Length > 0 &
              searchRow.Text.Length > 0 &
              searchColumn.Text.Length > 0 &
              cmbSearchSide.Text.Length > 0 &
              cmbSearchStatus.Text.Length > 0 
              )
          {
              MessageBox.Show("No");
          }
          else if (

              searchPaperSetCode.Text.Length > 0 &


              searchRow.Text.Length > 0 &
              searchColumn.Text.Length > 0 &
              cmbSearchSide.Text.Length > 0 &
              cmbSearchStatus.Text.Length > 0
              )
          {
              MessageBox.Show("No");
          }
          else if (

              searchPaperSetCode.Text.Length > 0 &


              searchColumn.Text.Length > 0 &
              cmbSearchSide.Text.Length > 0 &
              cmbSearchStatus.Text.Length > 0
              )
          {
              MessageBox.Show("No");
          }
          else if (

              searchPaperSetCode.Text.Length > 0 &

              cmbSearchSide.Text.Length > 0 &
              cmbSearchStatus.Text.Length > 0
              )
          {
              MessageBox.Show("No");
          }
          else if (

              searchPaperSetCode.Text.Length > 0 &

              cmbSearchStatus.Text.Length > 0
              )
          {
              MessageBox.Show("No");
          }
          else if (

              searchPaperSetCode.Text.Length > 0
              )
          {
              MessageBox.Show("No");
          }
          else if (
               searchSubjectName.Text.Length > 0 &

              searchPaperSetCode.Text.Length > 0 &
              searchSubjectCode.Text.Length > 0 &
              cmbSearchMedium.Text.Length > 0 &
              cmbSearchFaculty.Text.Length > 0 &

              cmbSearchDepartment.Text.Length > 0 &
              cmbSearchDegree.Text.Length > 0 &
              cmbSearchSemester.Text.Length > 0 &
              searchBatchName.Text.Length > 0 &
              txtSearch.Text.Length > 0 &

              cmbSearchYear.Text.Length > 0 &
              searchRow.Text.Length > 0 &
              searchColumn.Text.Length > 0 &
              cmbSearchSide.Text.Length > 0 &
              cmbSearchStatus.Text.Length > 0
              )
          {
              MessageBox.Show("No");
          }
          else if (
              searchSubjectName.Text.Length > 0 &


             searchSubjectCode.Text.Length > 0 &
             cmbSearchMedium.Text.Length > 0 &
             cmbSearchFaculty.Text.Length > 0 &

             cmbSearchDepartment.Text.Length > 0 &
             cmbSearchDegree.Text.Length > 0 &
             cmbSearchSemester.Text.Length > 0 &
             searchBatchName.Text.Length > 0 &
             txtSearch.Text.Length > 0 &

             cmbSearchYear.Text.Length > 0 &
             searchRow.Text.Length > 0 &
             searchColumn.Text.Length > 0 &
             cmbSearchSide.Text.Length > 0 &
             cmbSearchStatus.Text.Length > 0
             )
          {
              MessageBox.Show("No");
          }
          else if (
              searchSubjectName.Text.Length > 0 &

             cmbSearchMedium.Text.Length > 0 &
             cmbSearchFaculty.Text.Length > 0 &

             cmbSearchDepartment.Text.Length > 0 &
             cmbSearchDegree.Text.Length > 0 &
             cmbSearchSemester.Text.Length > 0 &
             searchBatchName.Text.Length > 0 &
             txtSearch.Text.Length > 0 &

             cmbSearchYear.Text.Length > 0 &
             searchRow.Text.Length > 0 &
             searchColumn.Text.Length > 0 &
             cmbSearchSide.Text.Length > 0 &
             cmbSearchStatus.Text.Length > 0
             )
          {
              MessageBox.Show("No");
          }
          else if (
              searchSubjectName.Text.Length > 0 &

             cmbSearchFaculty.Text.Length > 0 &

             cmbSearchDepartment.Text.Length > 0 &
             cmbSearchDegree.Text.Length > 0 &
             cmbSearchSemester.Text.Length > 0 &
             searchBatchName.Text.Length > 0 &
             txtSearch.Text.Length > 0 &

             cmbSearchYear.Text.Length > 0 &
             searchRow.Text.Length > 0 &
             searchColumn.Text.Length > 0 &
             cmbSearchSide.Text.Length > 0 &
             cmbSearchStatus.Text.Length > 0
             )
          {
              MessageBox.Show("No");
          }
          else if (
              searchSubjectName.Text.Length > 0 &


             cmbSearchDepartment.Text.Length > 0 &
             cmbSearchDegree.Text.Length > 0 &
             cmbSearchSemester.Text.Length > 0 &
             searchBatchName.Text.Length > 0 &
             txtSearch.Text.Length > 0 &

             cmbSearchYear.Text.Length > 0 &
             searchRow.Text.Length > 0 &
             searchColumn.Text.Length > 0 &
             cmbSearchSide.Text.Length > 0 &
             cmbSearchStatus.Text.Length > 0
             )
          {
              MessageBox.Show("No");
          }
          else if (
              searchSubjectName.Text.Length > 0 &

             cmbSearchDegree.Text.Length > 0 &
             cmbSearchSemester.Text.Length > 0 &
             searchBatchName.Text.Length > 0 &
             txtSearch.Text.Length > 0 &

             cmbSearchYear.Text.Length > 0 &
             searchRow.Text.Length > 0 &
             searchColumn.Text.Length > 0 &
             cmbSearchSide.Text.Length > 0 &
             cmbSearchStatus.Text.Length > 0
             )
          {
              MessageBox.Show("No");
          }
          else if (
              searchSubjectName.Text.Length > 0 &

             cmbSearchSemester.Text.Length > 0 &
             searchBatchName.Text.Length > 0 &
             txtSearch.Text.Length > 0 &

             cmbSearchYear.Text.Length > 0 &
             searchRow.Text.Length > 0 &
             searchColumn.Text.Length > 0 &
             cmbSearchSide.Text.Length > 0 &
             cmbSearchStatus.Text.Length > 0
             )
          {
              MessageBox.Show("No");
          }
          else if (
              searchSubjectName.Text.Length > 0 &

             searchBatchName.Text.Length > 0 &
             txtSearch.Text.Length > 0 &

             cmbSearchYear.Text.Length > 0 &
             searchRow.Text.Length > 0 &
             searchColumn.Text.Length > 0 &
             cmbSearchSide.Text.Length > 0 &
             cmbSearchStatus.Text.Length > 0
             )
          {
              MessageBox.Show("No");
          }

          else if (
              searchSubjectName.Text.Length > 0 &

             txtSearch.Text.Length > 0 &

             cmbSearchYear.Text.Length > 0 &
             searchRow.Text.Length > 0 &
             searchColumn.Text.Length > 0 &
             cmbSearchSide.Text.Length > 0 &
             cmbSearchStatus.Text.Length > 0
             )
          {
              MessageBox.Show("No");
          }
          else if (
              searchSubjectName.Text.Length > 0 &

             cmbSearchYear.Text.Length > 0 &
             searchRow.Text.Length > 0 &
             searchColumn.Text.Length > 0 &
             cmbSearchSide.Text.Length > 0 &
             cmbSearchStatus.Text.Length > 0
             )
          {
              MessageBox.Show("No");
          }
          else if (
              searchSubjectName.Text.Length > 0 &

             searchRow.Text.Length > 0 &
             searchColumn.Text.Length > 0 &
             cmbSearchSide.Text.Length > 0 &
             cmbSearchStatus.Text.Length > 0
             )
          {
              MessageBox.Show("No");
          }
          else if (
              searchSubjectName.Text.Length > 0 &

             searchColumn.Text.Length > 0 &
             cmbSearchSide.Text.Length > 0 &
             cmbSearchStatus.Text.Length > 0
             )
          {
              MessageBox.Show("No");
          }
          else if (
              searchSubjectName.Text.Length > 0 &

             cmbSearchSide.Text.Length > 0 &
             cmbSearchStatus.Text.Length > 0
             )
          {
              MessageBox.Show("No");
          }
          else if (
              searchSubjectName.Text.Length > 0 &

             cmbSearchStatus.Text.Length > 0
             )
          {
              MessageBox.Show("No");
          }
          else if (
              searchSubjectName.Text.Length > 0 
             )
          {
              MessageBox.Show("No");
          }
          else
          {

          }*/
    }
    }
}
