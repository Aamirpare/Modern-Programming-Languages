using System.Data.Entity;

namespace EFCodeFirst.Data
{
    public class SalesContext : DbContext
    {
        public SalesContext() : base("name=SalesManagerConnection")
        {
            
        }
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
