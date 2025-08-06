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
    public class RolManager : IRolService
    {
        IRolDal _rolDal;

        public RolManager(IRolDal rolDal)
        {
            _rolDal = rolDal;
        }

        public void RolAdd(Rol rol)
        {
            _rolDal.Insert(rol);
        }

        public Rol RolById(int id)
        {
            return _rolDal.GetById(id);
        }

        public void RolDelete(Rol rol)
        {
            _rolDal.Delete(rol);
        }

        public List<Rol> RolListAll()
        {
            return _rolDal.GetListAll();
        }

        public void RolUpdate(Rol rol)
        {
            _rolDal.Update(rol);
        }
    }
}
