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
            name.Text = desc.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

            paperName = name.Text;
            description = desc.Text;

            

            Paper paper = new Paper(name.Text.Trim(), desc.Text.Trim());
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

            DbPaper.DisplayAndSearch("SELECT ID, Name, Description FROM paper", dtDataGridView);

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
                name.Text = Convert.ToString(dtDataGridView.Rows[e.RowIndex].Cells[3].Value);
                desc.Text = Convert.ToString(dtDataGridView.Rows[e.RowIndex].Cells[4].Value);
                id = Convert.ToString(dtDataGridView.Rows[e.RowIndex].Cells[2].Value);




                return;
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            Paper paper = new Paper(name.Text.Trim(), desc.Text.Trim());
            DbPaper.UpdatePaper(paper, id);

            Clear();
            Display();
        }
    }
}
