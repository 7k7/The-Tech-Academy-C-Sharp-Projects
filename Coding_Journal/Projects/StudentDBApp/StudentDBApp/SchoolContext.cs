using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDBApp
{
    // Represents the database context for the Student database
    public class StudentContext : DbContext
    {
        public StudentContext() : base() { }
        // Provides the DbSet of type Student class called Students
        public DbSet<Student> Students { get; set; }
    }
}
