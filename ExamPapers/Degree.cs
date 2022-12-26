using System;
using System.Collections.Generic;
using System.Text;

namespace ExamPapers
{
    class Degree
    {
        public string facultyName { get; set; }
        public string departmentName { get; set; }
        public string degreeName { get; set; }

        public Degree(string facultyName, string departmentName, string degreeName)
        {
            this.facultyName = facultyName;
            this.departmentName = departmentName;
            this.degreeName = degreeName;
        }
    }
}
