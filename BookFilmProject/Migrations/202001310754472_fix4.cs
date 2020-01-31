namespace BookFilmProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Libro", "Created");
            DropColumn("dbo.Pelicula", "Created");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pelicula", "Created", c => c.DateTime());
            AddColumn("dbo.Libro", "Created", c => c.DateTime());
        }
    }
}
