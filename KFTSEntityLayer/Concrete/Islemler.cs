using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSEntityLayer.Concrete
{
    public class Islemler
    {
        [Key]
        public int IslemId { get; set; }
        public string IslemTuru { get; set; }
        public string IslemMiktar { get; set; }
        public string IslemAciklama { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string KullaniciAdiSoyadi { get; set; }
    }
}
