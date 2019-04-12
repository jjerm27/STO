namespace STO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boxes",
                c => new
                    {
                        BoxId = c.Int(nullable: false, identity: true),
                        FilialId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BoxId)
                .ForeignKey("dbo.Filials", t => t.FilialId, cascadeDelete: true)
                .Index(t => t.FilialId);
            
            CreateTable(
                "dbo.Filials",
                c => new
                    {
                        FilialId = c.Int(nullable: false, identity: true),
                        FilialAdress = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FilialId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        MasterId = c.String(nullable: false, maxLength: 128),
                        ManagerId = c.String(nullable: false, maxLength: 128),
                        BoxId = c.Int(nullable: false),
                        CarId = c.Int(nullable: false),
                        Comment = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Boxes", t => t.BoxId, cascadeDelete: true)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ManagerId, cascadeDelete: false)
                .ForeignKey("dbo.AspNetUsers", t => t.MasterId, cascadeDelete: false)
                .Index(t => t.MasterId)
                .Index(t => t.ManagerId)
                .Index(t => t.BoxId)
                .Index(t => t.CarId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        CarNumber = c.String(nullable: false),
                        CarMark = c.String(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.CarId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Sex = c.String(nullable: false),
                        Specialize = c.String(),
                        Status = c.String(),
                        Filial_Id = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        BirthDay = c.DateTime(nullable: false),
                        Adress = c.String(nullable: false),
                        Photo = c.String(nullable: false),
                        Date_Of_Create = c.DateTime(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        Filial_FilialId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Filials", t => t.Filial_FilialId)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex")
                .Index(t => t.Filial_FilialId);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.OrderServices",
                c => new
                    {
                        OrderServiceId = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderServiceId)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ServiceId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HumanTime = c.Double(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.ServiceId);
            
            CreateTable(
                "dbo.StatusOrders",
                c => new
                    {
                        StatusOrderId = c.Int(nullable: false, identity: true),
                        StatusId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StatusOrderId)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.StatusId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        StatusName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StatusId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.StatusOrders", "StatusId", "dbo.Status");
            DropForeignKey("dbo.StatusOrders", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderServices", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.OrderServices", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "MasterId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Orders", "ManagerId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Orders", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "Filial_FilialId", "dbo.Filials");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Cars", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Orders", "CarId", "dbo.Cars");
            DropForeignKey("dbo.Orders", "BoxId", "dbo.Boxes");
            DropForeignKey("dbo.Boxes", "FilialId", "dbo.Filials");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.StatusOrders", new[] { "OrderId" });
            DropIndex("dbo.StatusOrders", new[] { "StatusId" });
            DropIndex("dbo.OrderServices", new[] { "ServiceId" });
            DropIndex("dbo.OrderServices", new[] { "OrderId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", new[] { "Filial_FilialId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Cars", new[] { "UserId" });
            DropIndex("dbo.Orders", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Orders", new[] { "CarId" });
            DropIndex("dbo.Orders", new[] { "BoxId" });
            DropIndex("dbo.Orders", new[] { "ManagerId" });
            DropIndex("dbo.Orders", new[] { "MasterId" });
            DropIndex("dbo.Boxes", new[] { "FilialId" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Status");
            DropTable("dbo.StatusOrders");
            DropTable("dbo.Services");
            DropTable("dbo.OrderServices");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Cars");
            DropTable("dbo.Orders");
            DropTable("dbo.Filials");
            DropTable("dbo.Boxes");
        }
    }
}
