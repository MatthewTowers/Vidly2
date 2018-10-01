namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Thriller'), ('Family'), ('Romance'), ('Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
