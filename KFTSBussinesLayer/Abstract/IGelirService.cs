using KFTSEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSBussinesLayer.Abstract
{
    public interface IGelirService
    {
        void GelirAdd(Gelir gelir);
        void GelirDelete(Gelir gelir);
        void GelirUpdate(Gelir gelir);
        List<Gelir> GelirListAll();
        Gelir GelirById(int id);
        List<Gelir> GelirWithTurAndKullanici(int id);
        List<Gelir> GelirByDate1Month();
        List<Gelir> GelirByDate6Month();
        List<Gelir> GelirByDate1Year();

    }
}
