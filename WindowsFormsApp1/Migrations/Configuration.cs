namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WindowsFormsApp1.Siniflar.KayitContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; // Bu(AutomaticMigrationsEnabled) özelliği sayesinde otomatik olarak veritabanını güncelletebiliyoruz.

        }

        protected override void Seed(WindowsFormsApp1.Siniflar.KayitContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
