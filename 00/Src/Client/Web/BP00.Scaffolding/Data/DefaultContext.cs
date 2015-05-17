using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BP00.Scaffolding.Domain;

namespace BP00.Scaffolding.Data
{
    public class DefaultContext : DbContext
    {

        public DefaultContext()
            :base("name=BP00-D")
        {
            
        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}