using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneModel.Models;//referanslardan ekledikten sonra burayı ekliyoruz

namespace kutuphaneDataAccess.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Kitaplar> Kitaplar { get; set; }
        public DbSet<Yazarlar> Yazarlar { get; set; }//burada yaazarlars da olabilirdi

    }
}
