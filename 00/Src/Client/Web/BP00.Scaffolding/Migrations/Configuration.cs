namespace BP00.Scaffolding.Migrations
{
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BP00.Scaffolding.Data.DefaultContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BP00.Scaffolding.Data.DefaultContext context)
        {
            DatabaseSeeders.Seed(context);
        }
    }
}
