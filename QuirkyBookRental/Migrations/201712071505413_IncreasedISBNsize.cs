namespace QuirkyBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncreasedISBNsize : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "ISBN", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "ISBN", c => c.String(nullable: false));
        }
    }
}
