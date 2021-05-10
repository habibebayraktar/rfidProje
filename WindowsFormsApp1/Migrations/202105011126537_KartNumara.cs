namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KartNumara : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblKisiler", "kartNumara", c => c.String(nullable: false, maxLength: 18));
            AlterColumn("dbo.tblKisiler", "HesKodu", c => c.String(nullable: false, maxLength: 20));
            CreateIndex("dbo.tblKisiler", "kartNumara", unique: true);
            CreateIndex("dbo.tblKisiler", "HesKodu", unique: true);
            CreateIndex("dbo.tblKisiler", "Tc", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.tblKisiler", new[] { "Tc" });
            DropIndex("dbo.tblKisiler", new[] { "HesKodu" });
            DropIndex("dbo.tblKisiler", new[] { "kartNumara" });
            AlterColumn("dbo.tblKisiler", "HesKodu", c => c.String(nullable: false));
            AlterColumn("dbo.tblKisiler", "kartNumara", c => c.String(nullable: false));
        }
    }
}
