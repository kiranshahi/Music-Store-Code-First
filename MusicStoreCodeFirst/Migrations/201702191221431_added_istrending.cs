namespace MusicStoreCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_istrending : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "IsTrending", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "IsTrending");
        }
    }
}
