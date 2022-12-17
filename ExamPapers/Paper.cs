using System;
using System.Collections.Generic;
using System.Text;

namespace ExamPapers
{
    class Paper
    {
        public string PaperName { get; set; } 
        public string Description { get; set; }

        public Paper(string paperName, string description)
        {
            PaperName = paperName;
            Description = description;
        }
    }
}
