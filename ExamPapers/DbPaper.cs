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
            string sql = "INSERT INTO paper VALUES(NULL, @paperSetCode, @subjectCode, @subjectName, @medium, @faculty, @department, @semester, @batchName, @date, @rowName, @columnName, @side, @year)";
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
            cmd.Parameters.Add("@date", MySqlDbType.VarChar).Value = paper.date;
            cmd.Parameters.Add("@rowName", MySqlDbType.VarChar).Value = paper.rowName;
            cmd.Parameters.Add("@columnName", MySqlDbType.VarChar).Value = paper.columnName;
            cmd.Parameters.Add("@side", MySqlDbType.VarChar).Value = paper.side;
            cmd.Parameters.Add("@year", MySqlDbType.VarChar).Value = paper.year;

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
                "year = @year" +
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
            cmd.Parameters.Add("@date", MySqlDbType.VarChar).Value = paper.date;
            cmd.Parameters.Add("@rowName", MySqlDbType.VarChar).Value = paper.rowName;
            cmd.Parameters.Add("@columnName", MySqlDbType.VarChar).Value = paper.columnName;
            cmd.Parameters.Add("@side", MySqlDbType.VarChar).Value = paper.side;
            cmd.Parameters.Add("@year", MySqlDbType.VarChar).Value = paper.year;
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
