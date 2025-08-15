using KFTSBussinesLayer.Abstract;
using KFTSDataAccessLayer.Abstract;
using KFTSEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSBussinesLayer.Concrete
{
    public class VarlikManager : IVarlikService
    {
        IVarlikDal _varlikDal;
        public VarlikManager(IVarlikDal varlikDal)
        {
            _varlikDal = varlikDal;
        }

        public List<Varlik> GetAll()
        {
            return _varlikDal.GetListAll();
        }

        public List<Varlik> GetVarlikWithTurAndKullanici(int id)
        {
            return _varlikDal.GetVarlikWithTurAndKullanici(id);
        }

        public void VarlikAdd(Varlik varlik)
        {
            _varlikDal.Insert(varlik);
        }

        public void VarlikDelete(Varlik varlik)
        {
            _varlikDal.Delete(varlik);
        }

        public void VarlikDeleteById(int id)
        {
            _varlikDal.VarlikDeleteById(id);
        }

        public void VarlikUpdate(Varlik varlik)
        {
            _varlikDal.Update(varlik);
        }
    }
}
