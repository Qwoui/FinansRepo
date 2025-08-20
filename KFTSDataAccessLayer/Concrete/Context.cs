using KFTSEntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSDataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB; database=KFTSDb; integrated security=true;");
        }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Kullanıcı> Kullanıcıs { get; set; }
        public DbSet<Gider> Giders { get; set; }
        public DbSet<Gelir> Gelirs { get; set; }
        public DbSet<Tur> Turs { get; set; }
        public DbSet<Varlik> Varliks { get; set; }
    }
}
