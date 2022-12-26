using System;
using System.Collections.Generic;
using System.Text;

namespace ExamPapers
{
    class Paper
    {
        public string paperSetCode { get; set; } 
        public string subjectCode { get; set; }
        public string subjectName { get; set; }
        public string medium { get; set; }
        public string faculty { get; set; }
        public string department { get; set; }
        public string semester { get; set; }
        public string year { get; set; }
        public string batchName { get; set; }
        public string date { get; set; }
        public string rowName { get; set; }
        public string columnName { get; set; }
        public string side { get; set; }
        public string qty { get; set; }
        public string status { get; set; }
        public string degreeName { get; set; }

        public Paper(string paperSetCode, string subjectCode, string subjectName, string medium, string faculty, string department, string semester, string year, string batchName, string date, string rowName, string columnName, string side, string qty, string status, string degreeName)
        {
            this.paperSetCode = paperSetCode;
            this.subjectCode = subjectCode;
            this.subjectName = subjectName;
            this.medium = medium;
            this.faculty = faculty;
            this.department = department;
            this.semester = semester;
            this.year = year;
            this.batchName = batchName;
            this.date = date;
            this.rowName = rowName;
            this.columnName = columnName;
            this.side = side;
            this.qty = qty;
            this.status = status;
            this.degreeName = degreeName;
        }
    }
}
