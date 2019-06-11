namespace DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedNotNullablePlusName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Users", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false));
            //AlterColumn("dbo.Books", "Publisher", c => c.String(nullable: false));
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Reviews", "Comment", c => c.String(nullable: false));
            AlterColumn("dbo.Roles", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Authors", "FirstName");
            DropColumn("dbo.Authors", "LastName");
            DropColumn("dbo.Users", "FirstName");
            DropColumn("dbo.Users", "LastName");

            DropColumn("dbo.Books", "Publisher");
            AddColumn("dbo.Books", "Publisher", c => c.String(nullable: false));

            //AlterColumn("dbo.Authors", "Born", c => c.String(nullable: true));
            //AlterColumn("dbo.Books", "Pages", c => c.String(nullable: true));
            //AlterColumn("dbo.Books", "Rating", c => c.String(nullable: true));
            //AlterColumn("dbo.Books", "Release", c => c.String(nullable: true));

            DropColumn("dbo.Authors", "Born");
            AddColumn("dbo.Authors", "Born", c => c.String(nullable: true));
            DropColumn("dbo.Books", "Pages");
            AddColumn("dbo.Books", "Pages", c => c.String(nullable: true));
            DropColumn("dbo.Books", "Rating");
            AddColumn("dbo.Books", "Rating", c => c.String(nullable: true));
            DropColumn("dbo.Books", "Release");
            AddColumn("dbo.Books", "Release", c => c.String(nullable: true));

        }

        public override void Down()
        {
            AddColumn("dbo.Users", "LastName", c => c.String());
            AddColumn("dbo.Users", "FirstName", c => c.String());
            AddColumn("dbo.Authors", "LastName", c => c.String());
            AddColumn("dbo.Authors", "FirstName", c => c.String());
            AlterColumn("dbo.Roles", "Name", c => c.String());
            AlterColumn("dbo.Reviews", "Comment", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            AlterColumn("dbo.Books", "Publisher", c => c.String());
            AlterColumn("dbo.Books", "Title", c => c.String());
            DropColumn("dbo.Users", "Name");
            DropColumn("dbo.Authors", "Name");
        }
    }
}
