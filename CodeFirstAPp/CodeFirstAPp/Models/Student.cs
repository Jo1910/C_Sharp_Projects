using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstAPp.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StFirstName  { get; set; }
        public string StLastName { get; set; }
        public string Email { get; set; }


        public int SubjectID { get; set; }
        public virtual Subject Subject { get; set; }
    }
}