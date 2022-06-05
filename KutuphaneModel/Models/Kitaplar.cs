using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneModel.Models
{
    public class Kitaplar
    {
        [Key]
        public int ID { get; set; }
        [StringLength(60),Required]
        public string KitapAdi { get; set; }
        [StringLength(60), Required]
        public string KitapYazar { get; set; }
        [StringLength(4)]
        public string BasimYili { get; set; }
        //public virtual List<Yazarlar> Yazarlar  { get; set; }=new List<Yazarlar>();
    }
}
