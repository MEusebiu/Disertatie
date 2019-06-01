namespace DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added2LinkTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AuthorBookLinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: false)
                .ForeignKey("dbo.Genres", t => t.AuthorId, cascadeDelete: false)
                .Index(t => t.BookId)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.GenreBookLinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        GenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: false)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: false)
                .Index(t => t.BookId)
                .Index(t => t.GenreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GenreBookLinks", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.GenreBookLinks", "BookId", "dbo.Books");
            DropForeignKey("dbo.AuthorBookLinks", "AuthorId", "dbo.Genres");
            DropForeignKey("dbo.AuthorBookLinks", "BookId", "dbo.Books");
            DropIndex("dbo.GenreBookLinks", new[] { "GenreId" });
            DropIndex("dbo.GenreBookLinks", new[] { "BookId" });
            DropIndex("dbo.AuthorBookLinks", new[] { "AuthorId" });
            DropIndex("dbo.AuthorBookLinks", new[] { "BookId" });
            DropTable("dbo.GenreBookLinks");
            DropTable("dbo.AuthorBookLinks");
        }
    }
}
