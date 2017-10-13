namespace Minder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class efijfeqjifqejfqeioi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profiles", "Profielfoto_ID", c => c.Int());
            CreateIndex("dbo.Profiles", "Profielfoto_ID");
            AddForeignKey("dbo.Profiles", "Profielfoto_ID", "dbo.Profiles", "ID");
            DropColumn("dbo.Profiles", "Profielfoto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Profiles", "Profielfoto", c => c.String());
            DropForeignKey("dbo.Profiles", "Profielfoto_ID", "dbo.Profiles");
            DropIndex("dbo.Profiles", new[] { "Profielfoto_ID" });
            DropColumn("dbo.Profiles", "Profielfoto_ID");
        }
    }
}
