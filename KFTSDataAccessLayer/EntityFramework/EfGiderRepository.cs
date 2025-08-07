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
    public class EfGiderRepository : GenericRepository<Gider>, IGiderDal
    {
        public List<Gider> GetGiderWithTypeAndUser(int id)
        {
            using (var r = new Context())
            {
                return r.Giders.Include(x => x.Tur).Where(z => z.KullaniciId == id).ToList();
            }
        }
    }
}
