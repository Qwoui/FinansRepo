using KFTSEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSBussinesLayer.Abstract
{
    public interface IIslemlerService
    {
        void IslemAdd(Islemler ıslemler);
        List<Islemler> GetAll();
    }
}
