namespace Minder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class belh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profiles", "Geslacht", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profiles", "Geslacht");
        }
    }
}
