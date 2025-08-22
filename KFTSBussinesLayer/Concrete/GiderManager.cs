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
    public class GiderManager : IGiderService
    {
        IGiderDal _giderDal;
        public GiderManager(IGiderDal giderDal)
        {
            _giderDal = giderDal;
        }
        public void GiderAdd(Gider gider)
        {
            _giderDal.Insert(gider);
        }

        public Gider GiderById(int id)
        {
            throw new NotImplementedException();
        }

        public void GiderDelete(Gider gider)
        {
            throw new NotImplementedException();
        }

        public List<Gider> GiderListAll()
        {
            return _giderDal.GetListAll();
        }

        public void GiderUpdate(Gider gider)
        {
            throw new NotImplementedException();
        }

        public List<Gider> GiderWithTurAndKullanici(int id)
        {
            return _giderDal.GetGiderWithTypeAndUser(id);
        }
    }
}
