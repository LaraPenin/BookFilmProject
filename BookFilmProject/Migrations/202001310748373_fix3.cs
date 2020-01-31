namespace BookFilmProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Libro", "Created", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Libro", "Created", c => c.DateTime());
        }
    }
}
