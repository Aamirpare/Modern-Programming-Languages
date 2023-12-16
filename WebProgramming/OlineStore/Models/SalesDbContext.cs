using System;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public class SalesContext : DbContext
    {
        public SalesContext() : base("SalesDbConnection")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

    }

}