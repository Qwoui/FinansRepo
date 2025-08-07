using KFTSEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSDataAccessLayer.Abstract
{
    public interface IGiderDal : IGenericDal<Gider>
    {
        List<Gider> GetGiderWithTypeAndUser(int id);
    }
}
