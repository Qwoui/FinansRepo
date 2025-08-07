using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSEntityLayer.Concrete
{
    public class Gider
    {
        [Key]
        public int GiderId { get; set; }
        public string GiderMiktar { get; set; }
        public int TurId { get; set; }
        public Tur Tur { get; set; }
        public int KullaniciId { get; set; }
    }
}
