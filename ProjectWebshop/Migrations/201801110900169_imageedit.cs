namespace ProjectWebshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imageedit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Image", c => c.String());
            DropColumn("dbo.Products", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Type", c => c.String());
            DropColumn("dbo.Products", "Image");
        }
    }
}
