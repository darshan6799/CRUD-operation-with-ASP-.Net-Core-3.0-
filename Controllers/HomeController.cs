using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPWebAPI.Model;
using ASPWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASPWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        private ILogger _logger;
        private ICustomersList _customerService;


        public HomeController(ILogger<HomeController> logger, ICustomersList customerService)
        {
            _logger = logger;
            _customerService = customerService;

        }

        [HttpGet("/api/customers")]
        public ActionResult<List<Customers>> GetProducts()
        {
            return _customerService.GetCustomers();
        }

        [HttpPost("/api/customers")]
        public ActionResult<Customers> AddProduct(Customers customers)
        {
            _customerService.AddCustomer(customers);
            return customers;
        }

        [HttpPut("/api/customers/{id}")]
        public ActionResult<Customers> UpdateCustomers(string id, Customers customers)
        {
            _customerService.UpdateCustomer(id, customers);
            return customers;
        }

        [HttpDelete("/api/customers/{id}")]
        public ActionResult<string> DeleteProduct(string id)
        {
            _customerService.DeleteCustomer(id);
            //_logger.LogInformation("products", _products);
            return id;
        }
    }
}