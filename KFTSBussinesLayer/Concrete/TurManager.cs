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
    public class TurManager : ITurService
    {
        ITurDal _turDal;

        public TurManager(ITurDal turDal)
        {
            _turDal = turDal;
        }
        public List<Tur> GetListAll()
        {
            return _turDal.GetListAll();
        }

        public List<Tur> GetTurForGelir()
        {
            return _turDal.GetTurForGelir();
        }

        public List<Tur> GetTurForGider()
        {
            return _turDal.GetTurForGider();
        }

        public List<Tur> GetTurForVarlik()
        {
            return _turDal.GetTurForVarlik();
        }
    }
}
