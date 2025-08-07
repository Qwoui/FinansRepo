using KFTSDataAccessLayer.Abstract;
using KFTSDataAccessLayer.Concrete;
using KFTSDataAccessLayer.Repositories;
using KFTSEntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSDataAccessLayer.EntityFramework
{
    public class EfKullanıcıRepository : GenericRepository<Kullanıcı>, IKullanıcıDal
    {
        public List<Kullanıcı> GetKullanıcısWithRoles()
        {
            using (var r = new Context()) {
                return r.Kullanıcıs.Include(x => x.Rol).ToList();
            }

        }

        public Kullanıcı GetKullanıcıWithRole(int id)
        {
            using (var r = new Context())
            {
                return r.Kullanıcıs.Include(x => x.Rol).FirstOrDefault(u => u.KullaniciId == id);
            }
        }
    }
}
