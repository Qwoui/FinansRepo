using KFTSEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSDataAccessLayer.Abstract
{
    public interface IGelirDal : IGenericDal<Gelir>
    {
        List<Gelir> GetGelirWithTypeAndUser(int id);
        List<Gelir> GetGelirByDate1Month();
        List<Gelir> GetGelirByDate6Month();
        List<Gelir> GetGelirByDate1Year();

    }
}
