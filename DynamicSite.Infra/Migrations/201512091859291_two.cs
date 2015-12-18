namespace DynamicSite.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class two : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menu", "IdMenuPai", c => c.Long());
            CreateIndex("dbo.Menu", "IdMenuPai");
            AddForeignKey("dbo.Menu", "IdMenuPai", "dbo.Menu", "IdMenu");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Menu", "IdMenuPai", "dbo.Menu");
            DropIndex("dbo.Menu", new[] { "IdMenuPai" });
            DropColumn("dbo.Menu", "IdMenuPai");
        }
    }
}
