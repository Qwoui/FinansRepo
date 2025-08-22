
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSEntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string AdSoyad { get; set; }
        public DateTime KayitTarihi { get; set; }
    }
}
