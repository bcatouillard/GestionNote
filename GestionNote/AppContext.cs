using GestionNote.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNote
{
    class AppContext : DbContext
    {
        public DbSet<User> GetUsers { get; set; }

        public DbSet<Student> GetStudents { get; set; }

        public DbSet<Teacher> GetTeachers { get; set; }
    }
}
