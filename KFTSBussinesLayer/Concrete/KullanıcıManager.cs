using KFTSBussinesLayer.Abstract;
using KFTSDataAccessLayer.Abstract;
using KFTSDataAccessLayer.EntityFramework;
using KFTSEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSBussinesLayer.Concrete
{
    
    public class KullanıcıManager : IKullanıcıService
    {
        IKullanıcıDal _kullaniciDal;
        public KullanıcıManager(IKullanıcıDal kullanıcıDal)
        {
            _kullaniciDal = kullanıcıDal;
        }
        public KullanıcıManager()
        {
            _kullaniciDal = new EfKullanıcıRepository();
        }
        public void KullanıcıAdd(Kullanıcı kullanıcı)
        {
            _kullaniciDal.Insert(kullanıcı);
        }

        public Kullanıcı KullanıcıById(int id)
        {
            return _kullaniciDal.GetById(id);
        }

        public void KullanıcıDelete(Kullanıcı kullanıcı)
        {
            _kullaniciDal.Delete(kullanıcı);
        }

        public List<Kullanıcı> KullanıcıListAll()
        {
            return _kullaniciDal.GetListAll();
        }

        public void KullanıcıUpdate(Kullanıcı kullanıcı)
        {
            _kullaniciDal.Update(kullanıcı);
        }

        public List<Kullanıcı> KullanıcıWithRoles()
        {
            return _kullaniciDal.GetKullanıcısWithRoles();
        }

        public Kullanıcı KullanıcıByIdWithRole(int id)
        {
            return _kullaniciDal.GetKullanıcıWithRole(id);
        }
    }
}
