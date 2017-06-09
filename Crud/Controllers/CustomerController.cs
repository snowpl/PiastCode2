using Crud.DTO;
using Crud.IServices;
using Crud.IServices.Command;
using Crud.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace Crud.Controllers
{
    public class CustomerController : BaseController
    {
        private readonly ICustomerQueryService _customerQueryService;
        private readonly ICustomerCommandService _customerCommandService;

        public CustomerController(ICustomerCommandService customerCommandService,
            ICustomerQueryService customerQueryService)
        {
            _customerCommandService = customerCommandService;
            _customerQueryService = customerQueryService;
        }

        public ActionResult Index()
        {
            var customers = _customerQueryService.GetAll();

            var result = customers.Select(x => Convert(x)).ToList();

            return View(result);
        }

        public ActionResult Create()
        {
            return View(new CustomerViewModel());
        }

        [HttpPost]
        public ActionResult Create(CustomerViewModel model)
        {
            if (!this.ModelState.IsValid)
                return SendErrorsToClientAsJson();

            _customerCommandService.AddNewCustomer(Convert(model));

            return Json(new { Result = "OK", Location = Url.Action("Index") });
        }


        [HttpPost]
        public ActionResult Edit(CustomerViewModel customerVM)
        {
            if (!this.ModelState.IsValid)
                return SendErrorsToClientAsJson();

            var customers = _customerCommandService.EditCustomer(Convert(customerVM));

            return Json(new { Result = "OK", Location = Url.Action("Index") });
        }

        public ActionResult Edit(int id)
        {
            var customerDTO = _customerQueryService.GetCustomerById(id);

            var customer = Convert(customerDTO);

            return View(customer);
        }

        public ActionResult Delete(int id)
        {
            _customerCommandService.DeleteCustomer(id);
            return RedirectToAction("Index");
        }

        private CustomerViewModel Convert(CustomerDTO customer)
        {
            var customerVM = new CustomerViewModel()
            {
                Id = customer.Id,
                Name = customer.Name,
                Surname = customer.Surname,
                Address = customer.Address,
                TelephoneNumber = customer.TelephoneNumber
            };
            return customerVM;
        }

        private CustomerDTO Convert(CustomerViewModel customer)
        {
            var customerVM = new CustomerDTO()
            {
                Id = customer.Id,
                Name = customer.Name,
                Surname = customer.Surname,
                Address = customer.Address,
                TelephoneNumber = customer.TelephoneNumber
            };
            return customerVM;
        }

    }
}