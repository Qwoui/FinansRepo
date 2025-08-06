using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSEntityLayer.Concrete
{
    public class Tur
    {
        [Key]
        public int TurId { get; set; }
        public string TurAdi { get; set; }
        public List<Gider> Giders { get; set; }
        public List<Gelir> Gelirs { get; set; }
        public List<Varlik> Varliks { get; set; }
    }
}
