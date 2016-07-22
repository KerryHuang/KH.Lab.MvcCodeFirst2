using System.Data.Entity;

namespace MvcCodeFirst.Models
{
    public class SampleContext : DbContext
    {
        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<SystemRole> SystemRoles { get; set; }

        public SampleContext()
            : base("name=DefaultConnection")
        {

        }
    }
}