namespace BookFilmProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Libro", "Leido");
            DropColumn("dbo.Pelicula", "Vista");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pelicula", "Vista", c => c.Boolean(nullable: false));
            AddColumn("dbo.Libro", "Leido", c => c.Boolean(nullable: false));
        }
    }
}
