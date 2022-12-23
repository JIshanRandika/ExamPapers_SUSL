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
        }

        private void btnAddFaculty_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty(
                facultyName.Text.Trim()
              

                );

            DbPaper.AddFaculty(faculty);
        }

        private void Data_Load(object sender, EventArgs e)
        {
            string query = "select facultyName from faculty";
            MySql.Data.MySqlClient.MySqlConnection con = DbPaper.GetConnection();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, con);
            cmd.CommandText = query;
            //con.Open();
            MySql.Data.MySqlClient.MySqlDataReader drd = cmd.ExecuteReader();
            while (drd.Read())
            {
                cmbFaculty.Items.Add(drd["facultyName"].ToString());
                
            }
        }
    }
}
