using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamPapers
{
    class DbPaper
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=papers";

            MySqlConnection con = new MySqlConnection(sql);

            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection !" + ex.Message);
            }
            return con;
        }

        public static void AddPaper(Paper paper)
        {
            string sql = "INSERT INTO paper VALUES(NULL, @paperSetCode, @subjectCode, @subjectName, @medium, @faculty, @department, @semester, @batchName, @date, @rowName, @columnName, @side, @year, @qty, @status, @degreeName)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("@paperSetCode", MySqlDbType.VarChar).Value = paper.paperSetCode;
            cmd.Parameters.Add("@subjectCode", MySqlDbType.VarChar).Value = paper.subjectCode;
            cmd.Parameters.Add("@subjectName", MySqlDbType.VarChar).Value = paper.subjectName;
            cmd.Parameters.Add("@medium", MySqlDbType.VarChar).Value = paper.medium;
            cmd.Parameters.Add("@faculty", MySqlDbType.VarChar).Value = paper.faculty;
            cmd.Parameters.Add("@department", MySqlDbType.VarChar).Value = paper.department;
            cmd.Parameters.Add("@semester", MySqlDbType.VarChar).Value = paper.semester;
            cmd.Parameters.Add("@batchName", MySqlDbType.VarChar).Value = paper.batchName;
            cmd.Parameters.Add("@date", MySqlDbType.DateTime).Value = Convert.ToDateTime(paper.date);
            cmd.Parameters.Add("@rowName", MySqlDbType.VarChar).Value = paper.rowName;
            cmd.Parameters.Add("@columnName", MySqlDbType.VarChar).Value = paper.columnName;
            cmd.Parameters.Add("@side", MySqlDbType.VarChar).Value = paper.side;
            cmd.Parameters.Add("@year", MySqlDbType.VarChar).Value = paper.year;
            cmd.Parameters.Add("@qty", MySqlDbType.VarChar).Value = paper.qty;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = paper.status;
            cmd.Parameters.Add("@degreeName", MySqlDbType.VarChar).Value = paper.degreeName;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Paper not insert" + ex.Message);
            }
            con.Close();
        }

        public static void AddFaculty(Faculty faculty)
        {
            string sql = "INSERT INTO faculty VALUES(NULL, @facultyName)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("@facultyName", MySqlDbType.VarChar).Value = faculty.facultyName;
       

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Faculty not insert" + ex.Message);
            }
            con.Close();
        }

        public static void AddDepartment(Department department)
        {
            string sql = "INSERT INTO department VALUES(NULL, @facultyName, @departmentName, (SELECT ID FROM faculty WHERE facultyName=@facultyName))";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("@facultyName", MySqlDbType.VarChar).Value = department.facultyName;
            cmd.Parameters.Add("@departmentName", MySqlDbType.VarChar).Value = department.departmentName;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Department not insert" + ex.Message);
            }
            con.Close();
        }
        public static void AddDegree(Degree degree)
        {
            string sql = "INSERT INTO degree VALUES(NULL, @facultyName, @departmentName, @degreeName)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("@facultyName", MySqlDbType.VarChar).Value = degree.facultyName;
            cmd.Parameters.Add("@departmentName", MySqlDbType.VarChar).Value = degree.departmentName;
            cmd.Parameters.Add("@degreeName", MySqlDbType.VarChar).Value = degree.degreeName;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Degree not insert" + ex.Message);
            }
            con.Close();
        }

        public static void getFaculty(Faculty faculty)
        {
           
        }

        public static void UpdatePaper(Paper paper, string id)
        {
            string sql = "UPDATE paper SET paperSetCode = @paperSetCode," +
                "subjectCode = @subjectCode," +
                "subjectName = @subjectName," +
                "medium = @medium," +
                "faculty = @faculty," +
                "department = @department," +
                "semester = @semester," +
                "batchName = @batchName," +
                "date = @date," +
                "rowName = @rowName," +
                "columnName = @columnName," +
                "side = @side," +
                "year = @year," +
                "qty = @qty," +
                "status = @status," +
                "degreeName = @degreeName" +
                " WHERE ID=@ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@paperSetCode", MySqlDbType.VarChar).Value = paper.paperSetCode;
            cmd.Parameters.Add("@subjectCode", MySqlDbType.VarChar).Value = paper.subjectCode;
            cmd.Parameters.Add("@subjectName", MySqlDbType.VarChar).Value = paper.subjectName;
            cmd.Parameters.Add("@medium", MySqlDbType.VarChar).Value = paper.medium;
            cmd.Parameters.Add("@faculty", MySqlDbType.VarChar).Value = paper.faculty;
            cmd.Parameters.Add("@department", MySqlDbType.VarChar).Value = paper.department;
            cmd.Parameters.Add("@semester", MySqlDbType.VarChar).Value = paper.semester;
            cmd.Parameters.Add("@batchName", MySqlDbType.VarChar).Value = paper.batchName;
            cmd.Parameters.Add("@date", MySqlDbType.DateTime).Value = Convert.ToDateTime(paper.date);
            cmd.Parameters.Add("@rowName", MySqlDbType.VarChar).Value = paper.rowName;
            cmd.Parameters.Add("@columnName", MySqlDbType.VarChar).Value = paper.columnName;
            cmd.Parameters.Add("@side", MySqlDbType.VarChar).Value = paper.side;
            cmd.Parameters.Add("@year", MySqlDbType.VarChar).Value = paper.year;
            cmd.Parameters.Add("@qty", MySqlDbType.VarChar).Value = paper.qty;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = paper.status;
            cmd.Parameters.Add("@degreeName", MySqlDbType.VarChar).Value = paper.degreeName;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Paper not update" + ex.Message);
            }
            con.Close();

        }

        public static void UpdateFaculty(Faculty faculty, string id)
        {
            string sql = "UPDATE faculty SET facultyName = @facultyName" +
                " WHERE ID=@ID";
            MessageBox.Show(id);
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@facultyName", MySqlDbType.VarChar).Value = faculty.facultyName;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Faculty Updated Successfully");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Faculty not update" + ex.Message);
            }
            con.Close();

        }
        public static void UpdateDepartment(Department department, string id)
        {
            string sql = "UPDATE department SET facultyName = @facultyName, departmentName = @departmentName" +
                " WHERE ID=@ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@facultyName", MySqlDbType.VarChar).Value = department.facultyName;
            cmd.Parameters.Add("@departmentName", MySqlDbType.VarChar).Value = department.departmentName;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Department not update" + ex.Message);
            }
            con.Close();

        }
        public static void UpdateDegree(Degree degree, string id)
        {
            string sql = "UPDATE degree SET facultyName = @facultyName, departmentName = @departmentName, degreeName = @degreeName" +
                " WHERE ID=@ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@facultyName", MySqlDbType.VarChar).Value = degree.facultyName;
            cmd.Parameters.Add("@departmentName", MySqlDbType.VarChar).Value = degree.departmentName;
            cmd.Parameters.Add("@degreeName", MySqlDbType.VarChar).Value = degree.degreeName;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Department not update" + ex.Message);
            }
            con.Close();

        }

        public static void DeletePaper(string id)
        {
            string sql = "DELETE FROM paper WHERE ID = @ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Paper not delete" + ex.Message);
            }
            con.Close();
        }

        public static void DeleteFaculty(string id)
        {
            string sql = "DELETE FROM faculty WHERE ID = @ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Faculty not delete" + ex.Message);
            }
            con.Close();
        }

        public static void DeleteDepartment(string id)
        {
            string sql = "DELETE FROM department WHERE ID = @ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Department not delete" + ex.Message);
            }
            con.Close();
        }
        public static void DeleteDegree(string id)
        {
            string sql = "DELETE FROM degree WHERE ID = @ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Degree not delete" + ex.Message);
            }
            con.Close();
        }
        public static void DisplayAndSearch (string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();


        }

       




    }
}
