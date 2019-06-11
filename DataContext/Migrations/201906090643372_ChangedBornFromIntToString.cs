namespace DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedBornFromIntToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Authors", "Born", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Authors", "Born", c => c.Int(nullable: false));
        }
    }
}
