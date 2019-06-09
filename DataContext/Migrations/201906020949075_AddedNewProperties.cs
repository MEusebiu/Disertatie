namespace DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Rating", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Books", "Pages", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "ImgPath", c => c.String());
            AddColumn("dbo.Authors", "Born", c => c.Int(nullable: false));
            AddColumn("dbo.Authors", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "City");
            DropColumn("dbo.Authors", "Born");
            DropColumn("dbo.Books", "ImgPath");
            DropColumn("dbo.Books", "Pages");
            DropColumn("dbo.Books", "Rating");
        }
    }
}
