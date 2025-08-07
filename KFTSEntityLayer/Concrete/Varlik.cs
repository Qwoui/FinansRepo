using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSEntityLayer.Concrete
{
    public class Varlik
    {
        public int VarlikId { get; set; }
        public string VarlikAdi { get; set; }
        public string VarlikFiyat { get; set; }
        public string VarlikAciklama { get; set; }
        public int TurId { get; set; }
        public Tur Tur { get; set; }
        public int KullaniciId { get; set; }
    }
}
