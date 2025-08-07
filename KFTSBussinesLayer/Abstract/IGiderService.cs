using KFTSEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSBussinesLayer.Abstract
{
    public interface IGiderService
    {
        void GiderAdd(Gider gider);
        void GiderDelete(Gider gider);
        void GiderUpdate(Gider gider);
        List<Gider> GiderListAll();
        Gider GiderById(int id);
        List<Gider> GiderWithTurAndKullanici(int id);
    }
}
