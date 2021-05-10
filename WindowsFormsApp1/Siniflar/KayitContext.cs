using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Siniflar
{
    public class KayitContext :DbContext
    {
        public KayitContext():base("KayitContext")
        {

        }

        public DbSet<Kisi> Kisiler { get; set; } //ramde içinde kisi tutabilen bir tablo oluşturuyor.

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }




    }
}
