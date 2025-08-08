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
    public class EfGelirRepository : GenericRepository<Gelir>, IGelirDal
    {
        public List<Gelir> GetGelirByDate1Month()
        {
            var tarih = DateTime.Today.AddMonths(-1);
            using (var r = new Context())
            {
                return r.Gelirs.Include(x => x.Tur).Where(z => z.GelirGirisTarihi <= tarih).ToList();
            }
        }

        public List<Gelir> GetGelirByDate1Year()
        {
            var tarih = DateTime.Today.AddYears(-1);
            using (var r = new Context())
            {
                return r.Gelirs.Include(x => x.Tur).Where(z => z.GelirGirisTarihi <= tarih).ToList();
            }
        }

        public List<Gelir> GetGelirByDate6Month()
        {
            var tarih = DateTime.Today.AddMonths(-6);
            using (var r = new Context())
            {
                return r.Gelirs.Include(x => x.Tur).Where(z => z.GelirGirisTarihi <= tarih).ToList();
            }
        }

        public List<Gelir> GetGelirWithTypeAndUser(int id)
        {
            using (var r = new Context())
            {
                return r.Gelirs.Include(x => x.Tur).Where(z => z.KullaniciId == id).ToList();
            }
        }
    }
}
