using KFTSEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSBussinesLayer.Abstract
{
    public interface ITurService
    {
        List<Tur> GetListAll();
        List<Tur> GetTurForGelir();
        List<Tur> GetTurForGider();
        List<Tur> GetTurForVarlik();
    }
}
