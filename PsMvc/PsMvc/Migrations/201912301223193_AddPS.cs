namespace PsMvc.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddPS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        OwnerId = c.Int(),
                        Type = c.Int(),
                        StatusId = c.Int(),
                        Importance = c.Int(nullable: false),
                        Cost = c.Decimal(precision: 18, scale: 2),
                        PeriodicityId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ps");
        }
    }
}
