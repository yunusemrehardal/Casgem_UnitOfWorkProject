using CasgemUOW.BusinessLayer.Abstract;
using CasgemUOW.EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace CasgemUOW.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICustomerProcessService _customerProcessService;
        private readonly ICustomerService _customerService;

        public DefaultController(ICustomerProcessService customerProcessService, ICustomerService customerService)
        {
            _customerProcessService = customerProcessService;
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProcess customerProcess)
        {
            var valueSender = _customerService.TGetByID(customerProcess.SenderID);
            var valueReceiver = _customerService.TGetByID(customerProcess.ReceiverID);

            valueReceiver.CustomerBalance += customerProcess.Amount;
            valueSender.CustomerBalance -= customerProcess.Amount;

            List<Customer> modifiedCustomer = new List<Customer>()
            {
                valueSender,
                valueReceiver
            };

            _customerService.TMultiUpdate(modifiedCustomer);
            _customerProcessService.TInsert(customerProcess);
            return RedirectToAction("CustomerProcessList");
        }
    }
}
