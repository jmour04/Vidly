namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoadMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Shrek', 3, '1/1/2022', '1/1/1999', 3)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Tommy Boy', 5, '3/1/2002', '3/1/1996', 5)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Black Sheep', 5, '5/1/2002', '5/1/1998', 2)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Billy Madison', 5, '1/1/2005', '9/15/1999', 1)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Grown-Ups', 3, '1/1/2014', '6/1/2012', 3)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Click', 4, '11/14/2018', '6/22/2005', 6)");
        }
        
        public override void Down()
        {
        }
    }
}
