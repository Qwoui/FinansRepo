using KFTSEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSBussinesLayer.Abstract
{
    public interface IRolService
    {
        void RolAdd(Rol rol);
        void RolDelete(Rol rol);
        void RolUpdate(Rol rol);
        List<Rol> RolListAll();
        Rol RolById(int id);
    }
}
