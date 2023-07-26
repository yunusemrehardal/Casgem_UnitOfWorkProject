using CasgemUOW.DataAccessLayer.Abstract;
using CasgemUOW.DataAccessLayer.Concrete;
using CasgemUOW.DataAccessLayer.Repositories;
using CasgemUOW.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemUOW.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public EfCustomerDal(Context context) : base(context)
        {
        }
    }
}
