namespace BookFilmProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Libro",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Author = c.String(nullable: false),
                        Year = c.Int(nullable: false),
                        Genre = c.String(),
                        Theme = c.String(),
                        Country = c.String(),
                        Language = c.String(),
                        Publisher = c.String(),
                        PendienteLeido = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Pelicula",
                c => new
                    {
                        FilmID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Director = c.String(nullable: false),
                        Year = c.Int(nullable: false),
                        Genre = c.String(),
                        Theme = c.String(),
                        Country = c.String(),
                        Language = c.String(),
                        Music = c.String(),
                        PendienteVista = c.Boolean(nullable: false),
                        LibroID = c.Int(),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FilmID)
                .ForeignKey("dbo.Libro", t => t.LibroID)
                .Index(t => t.LibroID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pelicula", "LibroID", "dbo.Libro");
            DropIndex("dbo.Pelicula", new[] { "LibroID" });
            DropTable("dbo.Pelicula");
            DropTable("dbo.Libro");
        }
    }
}
