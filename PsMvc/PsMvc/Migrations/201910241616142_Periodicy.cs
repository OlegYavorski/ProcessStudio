namespace PsMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Periodicy : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Periodicies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Periodicies");
        }
    }
}
