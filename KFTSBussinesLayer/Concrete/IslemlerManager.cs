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
    public class IslemlerManager : IIslemlerService
    {
        IIslemlerDal _islemlerDal;

        public IslemlerManager(IIslemlerDal islemlerDal)
        {
            _islemlerDal = islemlerDal;
        }

        public List<Islemler> GetAll()
        {
            return _islemlerDal.GetListAll();
        }

        public void IslemAdd(Islemler ıslemler)
        {
            _islemlerDal.Insert(ıslemler);
        }
    }
}
