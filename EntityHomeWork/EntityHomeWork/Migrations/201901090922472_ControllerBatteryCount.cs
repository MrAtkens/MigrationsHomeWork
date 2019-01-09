namespace EntityHomeWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ControllerBatteryCount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RemoteControllers", "BatteryCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RemoteControllers", "BatteryCount");
        }
    }
}
