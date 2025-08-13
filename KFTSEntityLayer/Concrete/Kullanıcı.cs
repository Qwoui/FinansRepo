using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSEntityLayer.Concrete
{
    public class Kullanıcı
    {
        [Key]
        public int KullaniciId { get; set; }
        public string KullaniciAdiSoyadi { get; set; }
        public string KullaniciEmail { get; set; }
        public string KullaniciSifre { get; set; }
        [NotMapped]
        public string KullaniciSifreTekrar { get; set; }
        public DateTime KullaniciOlusturulmaTarihi { get; set; }
        public int RolId { get; set; }
        public Rol Rol { get; set; }
    }
}
