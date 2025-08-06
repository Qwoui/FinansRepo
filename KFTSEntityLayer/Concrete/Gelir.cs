using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSEntityLayer.Concrete
{
    public class Gelir
    {
        [Key]
        public int GelirId { get; set; }
        public string GelirMiktar { get; set; }
        public int TurId { get; set; }
        public Tur Tur { get; set; }

    }
}
