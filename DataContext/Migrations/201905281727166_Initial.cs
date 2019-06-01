namespace DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Release", c => c.Int(nullable: false));
            DropColumn("dbo.Books", "ReleaseDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "ReleaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Books", "Release");
        }
    }
}
