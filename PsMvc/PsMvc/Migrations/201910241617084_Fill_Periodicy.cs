namespace PsMvc.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Fill_Periodicy : DbMigration
    {
        public override void Up()
        {
            Sql(@"  SET IDENTITY_INSERT [dbo].[Periodicies] ON

                    INSERT INTO Periodicies (Id, Name) VALUES (1,'Hourly');
                    INSERT INTO Periodicies(Id, Name) VALUES(2, 'Daily');
                    INSERT INTO Periodicies (Id, Name) VALUES (3,'Weekly');
                    INSERT INTO Periodicies (Id, Name) VALUES (4,'Monthly');
                    INSERT INTO Periodicies (Id, Name) VALUES (5,'Annual');

                    SET IDENTITY_INSERT[dbo].[Periodicies] OFF
                ");
        }

        public override void Down()
        {
        }
    }
}
