using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSEntityLayer.Concrete
{
    public class Rol
    {
        [Key]
        public int RolId { get; set; }
        public string RolAdi { get; set; }

        public List<Kullanıcı> Kullanıcıs { get; set; }
    }
}
