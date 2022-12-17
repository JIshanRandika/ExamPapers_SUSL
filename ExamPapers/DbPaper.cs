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
            string sql = "INSERT INTO paper VALUES(NULL, @Name, @Description)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = paper.PaperName;
            cmd.Parameters.Add("@Description", MySqlDbType.VarChar).Value = paper.Description;

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
            string sql = "UPDATE paper SET Name = @Name, Description = @Description WHERE ID=@ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Name",MySqlDbType.VarChar).Value = paper.PaperName;
            cmd.Parameters.Add("@Description", MySqlDbType.VarChar).Value = paper.Description;
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
