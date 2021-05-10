namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isimDegisti : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblKisiler", "HesKodu", c => c.String(nullable: false));
            DropColumn("dbo.tblKisiler", "Hes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblKisiler", "Hes", c => c.String(nullable: false));
            DropColumn("dbo.tblKisiler", "HesKodu");
        }
    }
}
