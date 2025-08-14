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
    public class EfVarlikRepository : GenericRepository<Varlik>, IVarlikDal
    {
        public List<Varlik> GetVarlikWithTurAndKullanici(int id)
        {
            using (var r = new Context())
            {
                return r.Varliks.Include(x=> x.Tur).Where(z=> z.KullaniciId == id).ToList();
            }
        }
        public void VarlikDeleteById(int id)
        {
            using (var r = new Context())
            {
                var entity = r.Varliks.FirstOrDefault(x => x.VarlikId == id);
                r.Varliks.Remove(entity);
            }
        }
        
    }
}
