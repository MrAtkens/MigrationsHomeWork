namespace EntityHomeWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DroneMaxSpeed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drones", "MaxSpeed", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Drones", "MaxSpeed");
        }
    }
}
