namespace BookFilmProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Libro", "Leido", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pelicula", "Vista", c => c.Boolean(nullable: false));
            DropColumn("dbo.Libro", "PendienteLeido");
            DropColumn("dbo.Pelicula", "PendienteVista");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pelicula", "PendienteVista", c => c.Boolean(nullable: false));
            AddColumn("dbo.Libro", "PendienteLeido", c => c.Boolean(nullable: false));
            DropColumn("dbo.Pelicula", "Vista");
            DropColumn("dbo.Libro", "Leido");
        }
    }
}
