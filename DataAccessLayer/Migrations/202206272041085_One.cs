namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class One : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Info = c.String(),
                        RegDate = c.DateTime(nullable: false),
                        DeleteStatus = c.Boolean(nullable: false),
                        ActivityCategory_Id = c.Int(),
                        Customer_id = c.Int(),
                        User_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.ActivityCategories", t => t.ActivityCategory_Id)
                .ForeignKey("dbo.Customers", t => t.Customer_id)
                .ForeignKey("dbo.Users", t => t.User_id)
                .Index(t => t.ActivityCategory_Id)
                .Index(t => t.Customer_id)
                .Index(t => t.User_id);
            
            CreateTable(
                "dbo.ActivityCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        DeleteStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        DeleteStatus = c.Boolean(nullable: false),
                        RegDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        InvoiceNumber = c.String(),
                        RegDate = c.DateTime(nullable: false),
                        IsCheckOut = c.Boolean(nullable: false),
                        DeleteStatus = c.Boolean(nullable: false),
                        CkeckOutDate = c.DateTime(),
                        Customer_id = c.Int(),
                        User_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Customers", t => t.Customer_id)
                .ForeignKey("dbo.Users", t => t.User_id)
                .Index(t => t.Customer_id)
                .Index(t => t.User_id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        DeleteStatus = c.Boolean(nullable: false),
                        Stock = c.Int(nullable: false),
                        SumPrice = c.Double(nullable: false),
                        RegDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        Picture = c.String(),
                        Status = c.Boolean(nullable: false),
                        DeleteStatus = c.Boolean(nullable: false),
                        RegDate = c.DateTime(nullable: false),
                        UserGroup_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.UserGroups", t => t.UserGroup_id)
                .Index(t => t.UserGroup_id);
            
            CreateTable(
                "dbo.Reminders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ReminderInfo = c.String(),
                        RegDate = c.DateTime(nullable: false),
                        DeleteStatus = c.Boolean(nullable: false),
                        ReminderDate = c.DateTime(nullable: false),
                        IsDone = c.Boolean(nullable: false),
                        Users_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.Users_id)
                .Index(t => t.Users_id);
            
            CreateTable(
                "dbo.UserGroups",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.UserAccessRoles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Section = c.String(),
                        CanEnter = c.Boolean(nullable: false),
                        CanCreate = c.Boolean(nullable: false),
                        CanUpdate = c.Boolean(nullable: false),
                        CanDelete = c.Boolean(nullable: false),
                        UserGroup_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.UserGroups", t => t.UserGroup_id)
                .Index(t => t.UserGroup_id);
            
            CreateTable(
                "dbo.ProductInvoices",
                c => new
                    {
                        Product_id = c.Int(nullable: false),
                        Invoice_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_id, t.Invoice_id })
                .ForeignKey("dbo.Products", t => t.Product_id, cascadeDelete: true)
                .ForeignKey("dbo.Invoices", t => t.Invoice_id, cascadeDelete: true)
                .Index(t => t.Product_id)
                .Index(t => t.Invoice_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserGroup_id", "dbo.UserGroups");
            DropForeignKey("dbo.UserAccessRoles", "UserGroup_id", "dbo.UserGroups");
            DropForeignKey("dbo.Reminders", "Users_id", "dbo.Users");
            DropForeignKey("dbo.Invoices", "User_id", "dbo.Users");
            DropForeignKey("dbo.Activities", "User_id", "dbo.Users");
            DropForeignKey("dbo.ProductInvoices", "Invoice_id", "dbo.Invoices");
            DropForeignKey("dbo.ProductInvoices", "Product_id", "dbo.Products");
            DropForeignKey("dbo.Invoices", "Customer_id", "dbo.Customers");
            DropForeignKey("dbo.Activities", "Customer_id", "dbo.Customers");
            DropForeignKey("dbo.Activities", "ActivityCategory_Id", "dbo.ActivityCategories");
            DropIndex("dbo.ProductInvoices", new[] { "Invoice_id" });
            DropIndex("dbo.ProductInvoices", new[] { "Product_id" });
            DropIndex("dbo.UserAccessRoles", new[] { "UserGroup_id" });
            DropIndex("dbo.Reminders", new[] { "Users_id" });
            DropIndex("dbo.Users", new[] { "UserGroup_id" });
            DropIndex("dbo.Invoices", new[] { "User_id" });
            DropIndex("dbo.Invoices", new[] { "Customer_id" });
            DropIndex("dbo.Activities", new[] { "User_id" });
            DropIndex("dbo.Activities", new[] { "Customer_id" });
            DropIndex("dbo.Activities", new[] { "ActivityCategory_Id" });
            DropTable("dbo.ProductInvoices");
            DropTable("dbo.UserAccessRoles");
            DropTable("dbo.UserGroups");
            DropTable("dbo.Reminders");
            DropTable("dbo.Users");
            DropTable("dbo.Products");
            DropTable("dbo.Invoices");
            DropTable("dbo.Customers");
            DropTable("dbo.ActivityCategories");
            DropTable("dbo.Activities");
        }
    }
}
