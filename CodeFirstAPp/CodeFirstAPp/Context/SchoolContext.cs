using CodeFirstAPp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstAPp.Context
{
    public class SchoolContext : DbContext
    {
        public DbSet<Subject> Subjects {get; set;}
        public DbSet<Student> Students { get; set; }
    }
}