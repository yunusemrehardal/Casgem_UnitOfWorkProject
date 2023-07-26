using CasgemUOW.BusinessLayer.Abstract;
using CasgemUOW.DataAccessLayer.Abstract;
using CasgemUOW.DataAccessLayer.UnitOfWork.Abstract;
using CasgemUOW.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemUOW.BusinessLayer.Concrete
{
    public class CustomerProcessManager : ICustomerProcessService
    {
        private readonly ICustomerProcessDal _customerProcessDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;
        public CustomerProcessManager(ICustomerProcessDal customerProcessDal, IUnitOfWorkDal unitOfWorkDal)
        {
            _customerProcessDal = customerProcessDal;
            _unitOfWorkDal = unitOfWorkDal;
        }

        public void TDelete(CustomerProcess t)
        {
            _customerProcessDal.Delete(t);
            _unitOfWorkDal.Save();
        }

        public CustomerProcess TGetByID(int id)
        {
            return _customerProcessDal.GetByID(id);
        }

        public List<CustomerProcess> TGetList()
        {
            return _customerProcessDal.GetList();
        }

        public void TInsert(CustomerProcess t)
        {
            _customerProcessDal.Insert(t);
            _unitOfWorkDal.Save();
        }

        public void TMultiUpdate(List<CustomerProcess> t)
        {
            _customerProcessDal.MultiUpdate(t);
            _unitOfWorkDal.Save();
        }

        public void TUpdate(CustomerProcess t)
        {
            _customerProcessDal.Update(t);
            _unitOfWorkDal.Save(); 
        }
    }
}
