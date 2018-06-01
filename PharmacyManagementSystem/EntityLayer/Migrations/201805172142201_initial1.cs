namespace EntityLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MedicineInfoes", "Medicine_Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MedicineInfoes", "Medicine_Quantity", c => c.Int(nullable: false));
        }
    }
}
