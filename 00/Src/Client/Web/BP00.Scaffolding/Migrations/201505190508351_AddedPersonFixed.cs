namespace BP00.Scaffolding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPersonFixed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "PhoneNumber");
        }
    }
}
