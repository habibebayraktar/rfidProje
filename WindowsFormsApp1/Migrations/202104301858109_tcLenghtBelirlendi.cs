namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tcLenghtBelirlendi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblKisiler", "Tc", c => c.String(nullable: false, maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblKisiler", "Tc", c => c.String(nullable: false));
        }
    }
}
