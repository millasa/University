using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using University.Models;

namespace University.DAL
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //prevents table names from being pluralized
        }
    }
}