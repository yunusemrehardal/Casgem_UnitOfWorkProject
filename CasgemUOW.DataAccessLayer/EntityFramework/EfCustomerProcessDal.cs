using CasgemUOW.DataAccessLayer.Abstract;
using CasgemUOW.DataAccessLayer.Concrete;
using CasgemUOW.DataAccessLayer.Repositories;
using CasgemUOW.EntityLayer.Concrate;

namespace CasgemUOW.DataAccessLayer.EntityFramework
{
    public class EfCustomerProcessDal : GenericRepository<CustomerProcess>, ICustomerProcessDal
    {
        public EfCustomerProcessDal(Context context) : base(context)
        {
        }
    }
}
