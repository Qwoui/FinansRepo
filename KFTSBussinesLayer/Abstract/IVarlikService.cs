using KFTSEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSBussinesLayer.Abstract
{
    public interface IVarlikService
    {
        void VarlikAdd(Varlik varlik);
        List<Varlik> GetVarlikWithTurAndKullanici(int id);
        List<Varlik> GetAll();
        void VarlikDelete(Varlik varlik);
        void VarlikDeleteById(int id);
    }
}
