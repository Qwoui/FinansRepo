using KFTSDataAccessLayer.Abstract;
using KFTSDataAccessLayer.Concrete;
using KFTSEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSDataAccessLayer.Repositories
{
   /* public class KullanıcıRepository : IKullanıcıDal
    {
        Context c = new Context();
        public Kullanıcı GetByIdKullanıcı(int id)
        {
            return c.Kullanıcıs.Find(id);
        }

        public void KullaniciAdd(Kullanıcı kullanıcı)
        {
            c.Add(kullanıcı);
            c.SaveChanges();
        }

        public void KullaniciRemove(Kullanıcı kullanıcı)
        {
            c.Remove(kullanıcı);
            c.SaveChanges();
        }

        public void KullaniciUpdate(Kullanıcı kullanıcı)
        {
            c.Update(kullanıcı);
            c.SaveChanges();
        }

        public List<Kullanıcı> ListAllKullanıcı()
        {
            return c.Kullanıcıs.ToList();
        }
    }*/
}
