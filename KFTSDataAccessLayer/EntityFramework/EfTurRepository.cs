using KFTSDataAccessLayer.Abstract;
using KFTSDataAccessLayer.Concrete;
using KFTSDataAccessLayer.Repositories;
using KFTSEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSDataAccessLayer.EntityFramework
{
    public class EfTurRepository : GenericRepository<Tur>, ITurDal
    {
        public List<Tur> GetTurForGelir()
        {
            using (var r = new Context())
            {
                return r.Turs.Where(z => z.TurTipi=="Gelir").ToList();
            }
        }

        public List<Tur> GetTurForGider()
        {
            using (var r = new Context())
            {
                return r.Turs.Where(z => z.TurTipi == "Gider").ToList();
            }
        }

        public List<Tur> GetTurForVarlik()
        {
            using (var r = new Context())
            {
                return r.Turs.Where(z => z.TurTipi == "Varlık").ToList();
            }
        }
    }
}
