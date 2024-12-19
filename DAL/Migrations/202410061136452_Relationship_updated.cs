namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relationship_updated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HealthMetrics", "MetricType", c => c.String());
            AddColumn("dbo.HealthMetrics", "Value", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.HealthMetrics", "Unit", c => c.String());
            AddColumn("dbo.HealthGoals", "GoalType", c => c.String());
            AddColumn("dbo.HealthGoals", "TargetValue", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.HealthGoals", "Unit", c => c.String());
            AddColumn("dbo.HealthGoals", "EndDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.HealthMetrics", "Weight");
            DropColumn("dbo.HealthMetrics", "SyBP");
            DropColumn("dbo.HealthMetrics", "DiBP");
            DropColumn("dbo.HealthGoals", "TargetWeight");
            DropColumn("dbo.HealthGoals", "TargetSyBP");
            DropColumn("dbo.HealthGoals", "TargetDiBP");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HealthGoals", "TargetDiBP", c => c.Int(nullable: false));
            AddColumn("dbo.HealthGoals", "TargetSyBP", c => c.Int(nullable: false));
            AddColumn("dbo.HealthGoals", "TargetWeight", c => c.Int(nullable: false));
            AddColumn("dbo.HealthMetrics", "DiBP", c => c.Int(nullable: false));
            AddColumn("dbo.HealthMetrics", "SyBP", c => c.Int(nullable: false));
            AddColumn("dbo.HealthMetrics", "Weight", c => c.Int(nullable: false));
            DropColumn("dbo.HealthGoals", "EndDate");
            DropColumn("dbo.HealthGoals", "Unit");
            DropColumn("dbo.HealthGoals", "TargetValue");
            DropColumn("dbo.HealthGoals", "GoalType");
            DropColumn("dbo.HealthMetrics", "Unit");
            DropColumn("dbo.HealthMetrics", "Value");
            DropColumn("dbo.HealthMetrics", "MetricType");
        }
    }
}
