using Microsoft.EntityFrameworkCore;
using Supersolid.Entities.Concrete;

namespace Supersolid.DataAccess.Concrete.EntityFramework.Contexts
{
    public class SupersolidContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=Supersolid; Trusted_Connection=true;");
        }

        public DbSet<Solution> Solutions { get; set; }
        public DbSet<Layer> Layers { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
