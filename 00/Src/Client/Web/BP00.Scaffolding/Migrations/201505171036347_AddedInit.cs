namespace BP00.Scaffolding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AvatarUrl = c.String(),
                        Gender = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DayOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        Street = c.String(),
                        Option = c.String(),
                        ZipCode = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                        Created = c.DateTime(),
                        Updated = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Person");
        }
    }
}
