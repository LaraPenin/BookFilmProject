namespace BookFilmProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Libro", "Created", c => c.DateTime());
            AlterColumn("dbo.Pelicula", "Created", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pelicula", "Created", c => c.DateTime());
            AlterColumn("dbo.Libro", "Created", c => c.DateTime());
        }
    }
}
