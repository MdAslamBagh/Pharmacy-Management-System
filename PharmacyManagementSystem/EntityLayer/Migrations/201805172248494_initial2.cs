namespace EntityLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MedicineInfoes", "Medicine_Available", c => c.Int(nullable: false));
            DropColumn("dbo.MedicineInfoes", "Medicine_Avaiable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MedicineInfoes", "Medicine_Avaiable", c => c.Int(nullable: false));
            DropColumn("dbo.MedicineInfoes", "Medicine_Available");
        }
    }
}
