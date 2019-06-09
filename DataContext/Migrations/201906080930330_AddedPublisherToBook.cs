namespace DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPublisherToBook : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Publisher", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Publisher");
        }
    }
}
