namespace MusicStoreCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_discount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "Discount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "Discount");
        }
    }
}
