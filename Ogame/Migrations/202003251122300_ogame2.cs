namespace Ogame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ogame2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Planets", "Name", c => c.String(maxLength: 20));
            AddColumn("dbo.Planets", "CaseNb", c => c.Int());
            AddColumn("dbo.Planets", "SolarSystem_Id", c => c.Long());
            AddColumn("dbo.Resources", "Name", c => c.String(maxLength: 20));
            AddColumn("dbo.Resources", "LastQuantity", c => c.Int());
            AddColumn("dbo.Resources", "LastUpdate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Resources", "Planet_Id", c => c.Long());
            AddColumn("dbo.SolarSystems", "Name", c => c.String(maxLength: 20));
            CreateIndex("dbo.Planets", "SolarSystem_Id");
            CreateIndex("dbo.Resources", "Planet_Id");
            AddForeignKey("dbo.Resources", "Planet_Id", "dbo.Planets", "Id");
            AddForeignKey("dbo.Planets", "SolarSystem_Id", "dbo.SolarSystems", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Planets", "SolarSystem_Id", "dbo.SolarSystems");
            DropForeignKey("dbo.Resources", "Planet_Id", "dbo.Planets");
            DropIndex("dbo.Resources", new[] { "Planet_Id" });
            DropIndex("dbo.Planets", new[] { "SolarSystem_Id" });
            DropColumn("dbo.SolarSystems", "Name");
            DropColumn("dbo.Resources", "Planet_Id");
            DropColumn("dbo.Resources", "LastUpdate");
            DropColumn("dbo.Resources", "LastQuantity");
            DropColumn("dbo.Resources", "Name");
            DropColumn("dbo.Planets", "SolarSystem_Id");
            DropColumn("dbo.Planets", "CaseNb");
            DropColumn("dbo.Planets", "Name");
        }
    }
}
