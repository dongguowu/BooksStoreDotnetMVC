namespace David.BooksStore.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "booksStore.Products",
                c => new
                    {
                        ProductId = c.Long(nullable: false, identity: true),
                        Author = c.String(nullable: false, maxLength: 50),
                        CategoryId = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        ImageData = c.Binary(),
                        ImageMimeType = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Title = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "booksStore.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        PasswordHash = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("booksStore.Users");
            DropTable("booksStore.Products");
        }
    }
}
