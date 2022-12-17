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

        string paperName;
        string description;
        string id;

        public Papers()
        {
            InitializeComponent();
            Display();
        }

        public void Clear()
        {
            paperSetCode.Text = subjectCode.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

            

            

            Paper paper = new Paper(paperSetCode.Text.Trim(), subjectCode.Text.Trim());
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

            DbPaper.DisplayAndSearch("SELECT ID, paperSetCode, subjectCode FROM paper", dtDataGridView);

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
                id = Convert.ToString(dtDataGridView.Rows[e.RowIndex].Cells[2].Value);




                return;
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            Paper paper = new Paper(paperSetCode.Text.Trim(), subjectCode.Text.Trim());
            DbPaper.UpdatePaper(paper, id);

            Clear();
            Display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DbPaper.DisplayAndSearch("SELECT ID, Name, Description FROM paper WHERE Name LIKE '%"+txtSearch.Text+"%'",dtDataGridView);
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
            cmbfaculty.Items.Add("Faculty of Management Studies");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
