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
        }
        public void Clear()
        {
            facultyName.Text
                = string.Empty;
        }
        public void Display()
        {
           

            DbPaper.DisplayAndSearch("SELECT ID," +
                "facultyName" +
                " FROM faculty", dtgFaculty);

        }

        private void Data_Load(object sender, EventArgs e)
        {
            string query = "select facultyName from faculty";
            string query2 = "select departmentName from department";
            MySql.Data.MySqlClient.MySqlConnection con = DbPaper.GetConnection();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, con);
            MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand(query2, con);
            cmd.CommandText = query;
            cmd2.CommandText = query2;
            //con.Open();
            MySql.Data.MySqlClient.MySqlDataReader drd = cmd.ExecuteReader();
            
            while (drd.Read())
            {
                cmbFaculty.Items.Add(drd["facultyName"].ToString());

                cmbFacultyDe.Items.Add(drd["facultyName"].ToString());
                
            }
            drd.Close();
            
             drd = cmd2.ExecuteReader();
            while (drd.Read())
            {
                cmbDepartment.Items.Add(drd["departmentName"].ToString());


            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            Department department = new Department(
                            facultyName.Text.Trim(),
                            departmentName.Text.Trim()

                            );

            DbPaper.AddDepartment(department);
        }
    }
}
