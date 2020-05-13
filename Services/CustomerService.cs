using ASPWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPWebAPI.Services
{
    public class CustomerService : ICustomersList
    {
        private List<Customers> _customerItems;

        public CustomerService()
        {
            _customerItems = new List<Customers>();
        }

        public List<Customers> GetCustomers()
        {
            return _customerItems;
        }

        public Customers AddCustomer(Customers customers)
        {
            _customerItems.Add(customers);
            return customers;
        }

        public Customers UpdateCustomer(string id, Customers customers)
        {
            for (var index = _customerItems.Count - 1; index >= 0; index--)
            {
                if (_customerItems[index].CustomerID == id)
                {
                    _customerItems[index] = customers;
                }
            }
            return customers;
        }

        public string DeleteCustomer(string id)
        {
            for (var index = _customerItems.Count - 1; index >= 0; index--)
            {
                if (_customerItems[index].CustomerID == id)
                {
                    _customerItems.RemoveAt(index);
                }
            }

            return id;
        }

        public Customers UpdateProduct(string id, Customers customer)
        {
            throw new NotImplementedException();
        }
    }
}
