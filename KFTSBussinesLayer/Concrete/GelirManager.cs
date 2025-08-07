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
    public class GelirManager : IGelirService
    {
        IGelirDal _gelirdal;
        public GelirManager(IGelirDal gelirDal)
        {
            _gelirdal = gelirDal;
        }
        public void GelirAdd(Gelir gelir)
        {
            _gelirdal.Insert(gelir);
        }

        public Gelir GelirById(int id)
        {
            return _gelirdal.GetById(id);
        }

        public void GelirDelete(Gelir gelir)
        {
            _gelirdal.Delete(gelir);
        }

        public List<Gelir> GelirListAll()
        {
            return _gelirdal.GetListAll();
        }

        public void GelirUpdate(Gelir gelir)
        {
            _gelirdal.Update(gelir);
        }

        public List<Gelir> GelirWithTurAndKullanici(int id)
        {
            return _gelirdal.GetGelirWithTypeAndUser(id);
        }
    }
}
