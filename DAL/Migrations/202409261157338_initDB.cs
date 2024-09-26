namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HealthDevices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        DeviceName = c.String(),
                        DeviceAddedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 10, unicode: false),
                        Password = c.String(nullable: false, maxLength: 10, unicode: false),
                        Email = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SharedDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Provider = c.String(),
                        DateShared = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.HealthGoals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        TargetWeight = c.Int(nullable: false),
                        TargetSyBP = c.Int(nullable: false),
                        TargetDiBP = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.HealthMetrics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        SyBP = c.Int(nullable: false),
                        DiBP = c.Int(nullable: false),
                        DateRecorded = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HealthMetrics", "UserId", "dbo.Users");
            DropForeignKey("dbo.HealthGoals", "UserId", "dbo.Users");
            DropForeignKey("dbo.HealthDevices", "UserId", "dbo.Users");
            DropForeignKey("dbo.SharedDatas", "UserId", "dbo.Users");
            DropIndex("dbo.HealthMetrics", new[] { "UserId" });
            DropIndex("dbo.HealthGoals", new[] { "UserId" });
            DropIndex("dbo.SharedDatas", new[] { "UserId" });
            DropIndex("dbo.HealthDevices", new[] { "UserId" });
            DropTable("dbo.HealthMetrics");
            DropTable("dbo.HealthGoals");
            DropTable("dbo.SharedDatas");
            DropTable("dbo.Users");
            DropTable("dbo.HealthDevices");
        }
    }
}
