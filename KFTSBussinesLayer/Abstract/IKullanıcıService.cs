using KFTSEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSBussinesLayer.Abstract
{
    public interface IKullanıcıService
    {
        void KullanıcıAdd(Kullanıcı kullanıcı);
        void KullanıcıDelete(Kullanıcı kullanıcı);
        void KullanıcıUpdate(Kullanıcı kullanıcı);
        List<Kullanıcı> KullanıcıListAll();
        Kullanıcı KullanıcıById(int id);
        List<Kullanıcı> KullanıcıWithRoles();
        Kullanıcı KullanıcıByIdWithRole(int id);
    }
}
