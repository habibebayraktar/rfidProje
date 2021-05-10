namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TarihEklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblKisiler",
                c => new
                    {
                        KisiId = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 70),
                        Soyad = c.String(nullable: false, maxLength: 70),
                        Hes = c.String(nullable: false),
                        Tc = c.String(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.KisiId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblKisiler");
        }
    }
}
