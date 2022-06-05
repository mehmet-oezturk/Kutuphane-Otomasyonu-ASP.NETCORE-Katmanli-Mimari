using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneModel.Models
{
    public class Yazarlar
    {
        [Key]
        public int YazarID { get; set; }
        [ForeignKey("Kitaplar")]
        public int KitapId { get; set; }
        public virtual Kitaplar Kitaplar { get; private set; } //önemli

        public string YazarAdSoyad { get; set; }
        [StringLength(60),Required]
        public string YazarAdres { get; set; }
        [StringLength(40)]
        public string YazarMail { get; set; }
    }
}
