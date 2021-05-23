using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstAPp.Models
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }

        public virtual List<Student> Students { get; set; }

    }
}