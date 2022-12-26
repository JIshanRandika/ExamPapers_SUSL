using System;
using System.Collections.Generic;
using System.Text;

namespace ExamPapers
{
    class Department
    {
        public string facultyName { get; set; }
        public string departmentName { get; set; }

        public Department(string facultyName, string departmentName)
        {
            this.facultyName = facultyName;
            this.departmentName = departmentName;
        }
    }
}
