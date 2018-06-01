namespace EntityLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Customer_Id = c.Int(nullable: false),
                        CustomerName = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        PostalCode = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeeInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        MobileNumber = c.String(),
                        Dob = c.DateTime(nullable: false),
                        Address = c.String(),
                        Email = c.String(),
                        Salary = c.Int(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MedicineInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Medicine_Id = c.Int(nullable: false),
                        Medicine_Name = c.String(),
                        Medicine_Catagory = c.String(),
                        Dosage = c.String(),
                        Manufacturer = c.String(),
                        Medicine_Quantity = c.Int(nullable: false),
                        Medicine_Avaiable = c.Int(nullable: false),
                        Entry_Date = c.DateTime(nullable: false),
                        Production_Date = c.DateTime(nullable: false),
                        Expire_Date = c.DateTime(nullable: false),
                        Buying_Price = c.Int(nullable: false),
                        Selling_Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Order_Id = c.Int(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                        Medicine_Id = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.String(),
                        Address = c.String(),
                        MobileNumber = c.String(),
                        UserType = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserInfoes");
            DropTable("dbo.OrderInfoes");
            DropTable("dbo.MedicineInfoes");
            DropTable("dbo.EmployeeInfoes");
            DropTable("dbo.CustomerInfoes");
        }
    }
}
