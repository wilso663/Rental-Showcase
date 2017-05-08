namespace RentalShowcase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Genres (Id, name) VALUES (1, 'Action') ");
            Sql("Insert Into Genres (Id, name) VALUES (2, 'Thriller') ");
            Sql("Insert Into Genres (Id, name) VALUES (3, 'Family') ");
            Sql("Insert Into Genres (Id, name) VALUES (4, 'Romance') ");
            Sql("Insert Into Genres (Id, name) VALUES (5, 'Comedy') ");
        }
        
        public override void Down()
        {
        }
    }
}
