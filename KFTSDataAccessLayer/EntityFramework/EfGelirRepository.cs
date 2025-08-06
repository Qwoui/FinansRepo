using KFTSDataAccessLayer.Abstract;
using KFTSDataAccessLayer.Repositories;
using KFTSEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSDataAccessLayer.EntityFramework
{
    public class EfGelirRepository : GenericRepository<Gelir>, IGelirDal
    {
    }
}
