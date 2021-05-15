using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Siniflar
{
    [Table("tblKisiler")]
     public class Kisi
    {

        public int KisiId { get; set; }

        [StringLength(70)]
        [Required] //null olamaz, bu bilgi boş geçilemez anlamına gelir
        public string Ad { get; set; }

        [StringLength(70)]
        [Required] //null olamaz, bu bilgi boş geçilemez anlamına gelir
        public string Soyad { get; set; }


        [StringLength(18)]
        [Required]
        [Index(IsUnique = true)] //tekillik
        public string kartNumara { get; set; }

        [StringLength(20)]
        [Required]
        [Index(IsUnique = true)]
        public string HesKodu { get; set; }

        
        [StringLength(11)]
        [Required]
        [Index(IsUnique = true)]
        public string Tc { get; set; }

        [Required]
        public DateTime KayitTarihi { get; set; }

    }
}
