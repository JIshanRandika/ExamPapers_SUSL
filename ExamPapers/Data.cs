using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExamPapers
{
    public partial class Data : Form
    {
        string id;
        public Data()
        {
            InitializeComponent();
            Display();
        }

        private void btnAddFaculty_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty(
                facultyName.Text.Trim()


                );

            DbPaper.AddFaculty(faculty);
            Display();
            comboLoader();
            Clear();
        }
        public void Clear()
        {
            facultyName.Text = departmentName.Text = degreeName.Text = cmbFaculty.Text = cmbFacultyDe.Text = cmbDepartment.Text
                = string.Empty;
        }
        public void Display()
        {


            DbPaper.DisplayAndSearch("SELECT ID," +
                "facultyName" +
                " FROM faculty", dtgFaculty);
            DbPaper.DisplayAndSearch("SELECT ID," +
                "facultyName," +
                "departmentName" +
                " FROM department", dtgDepartment);
            DbPaper.DisplayAndSearch("SELECT ID," +
                "facultyName," +
                "departmentName," +
                "degreeName" +
                " FROM degree", dtgDegree);

        }

        public void comboLoader()
        {
            cmbFaculty.Items.Clear();
            cmbFacultyDe.Items.Clear();
            cmbDepartment.Items.Clear();

            string query = "select facultyName from faculty";
            
            MySql.Data.MySqlClient.MySqlConnection con = DbPaper.GetConnection();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, con);
            
            cmd.CommandText = query;
            
            //con.Open();
            MySql.Data.MySqlClient.MySqlDataReader drd = cmd.ExecuteReader();

            while (drd.Read())
            {

                cmbFaculty.Items.Add(drd["facultyName"].ToString());

                cmbFacultyDe.Items.Add(drd["facultyName"].ToString());

            }
            drd.Close();

            
        }

        private void Data_Load(object sender, EventArgs e)
        {
            comboLoader();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            Department department = new Department(
                            cmbFaculty.Text.Trim(),
                            departmentName.Text.Trim()

                            );

            DbPaper.AddDepartment(department);
            Display();
            comboLoader();
            Clear();
        }

        private void btnAddDegree_Click(object sender, EventArgs e)
        {
            Degree degree = new Degree(
                            cmbFacultyDe.Text.Trim(),
                            cmbDepartment.Text.Trim(),
                            degreeName.Text.Trim()

                            );

            DbPaper.AddDegree(degree);
            Display();
            comboLoader();
            Clear();
        }

        private void dtgFaculty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Delete
                if (MessageBox.Show("Are you want to delete faculty record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbPaper.DeleteFaculty(dtgFaculty.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
            }
            if (e.ColumnIndex == 1)
            {

                int row = e.RowIndex;

                id = dtgFaculty.Rows[row].Cells[2].Value.ToString();
                facultyName.Text = dtgFaculty.Rows[row].Cells[3].Value.ToString();
                
            }
        }

        private void btnUpdateFaculty_Click(object sender, EventArgs e)
        {

            Faculty faculty = new Faculty(
                facultyName.Text.Trim()
                

                );
            DbPaper.UpdateFaculty(faculty, id);

            Clear();
            comboLoader();
            Display();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtgDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Delete
                if (MessageBox.Show("Are you want to delete department record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbPaper.DeleteDepartment(dtgDepartment.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
            }
            if (e.ColumnIndex == 1)
            {

                int row = e.RowIndex;

                id = dtgDepartment.Rows[row].Cells[2].Value.ToString();
                cmbFaculty.Text = dtgDepartment.Rows[row].Cells[3].Value.ToString();
                departmentName.Text = dtgDepartment.Rows[row].Cells[4].Value.ToString();

            }
        }

        private void btnUpdateDepartment_Click(object sender, EventArgs e)
        {

            Department department = new Department(
                cmbFaculty.Text.Trim(),
                departmentName.Text.Trim()


                );
            DbPaper.UpdateDepartment(department, id);

            Clear();
            comboLoader();
            Display();
        }

        private void dtgDegree_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Delete
                if (MessageBox.Show("Are you want to delete Degree record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbPaper.DeleteDegree(dtgDegree.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
            }
            if (e.ColumnIndex == 1)
            {

                int row = e.RowIndex;

                id = dtgDegree.Rows[row].Cells[2].Value.ToString();
                cmbFacultyDe.Text = dtgDegree.Rows[row].Cells[3].Value.ToString();
                cmbDepartment.Text = dtgDegree.Rows[row].Cells[4].Value.ToString();
                degreeName.Text = dtgDegree.Rows[row].Cells[5].Value.ToString();

            }
        }

        private void cmbFacultyDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cmbDepartment.Items.Clear();

            
            string query2 = "select departmentName from department WHERE facultyName = '"+cmbFacultyDe.Text.ToString()+"'";
            MySql.Data.MySqlClient.MySqlConnection con = DbPaper.GetConnection();
            MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand(query2, con);
        
            cmd2.CommandText = query2;
            //con.Open();
            MySql.Data.MySqlClient.MySqlDataReader drd = cmd2.ExecuteReader();


            while (drd.Read())
            {
                cmbDepartment.Items.Add(drd["departmentName"].ToString());


            }
        }

        private void btnUpdateDegree_Click(object sender, EventArgs e)
        {
            Degree degree = new Degree(
               cmbFacultyDe.Text.Trim(),
               cmbDepartment.Text.Trim(),
               degreeName.Text.Trim()


               );
            DbPaper.UpdateDegree(degree, id);

            Clear();
            comboLoader();
            Display();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}