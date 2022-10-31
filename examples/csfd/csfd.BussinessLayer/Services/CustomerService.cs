using csfd.BussinessLayer.Mapper;
using csfd.BussinessLayer.Models;
using csfd.DataLayer;
using System.Data;

namespace csfd.BussinessLayer.Services
{
    public class CustomerService
    {
        private readonly CustomerTableDataGateway customerTableDataGateway;
        private readonly IdentityMap<Customer> identityMap;

        public CustomerService()
        {
            customerTableDataGateway = new CustomerTableDataGateway();
            identityMap = new IdentityMap<Customer>();
        }

        public List<Customer> GetAllCustomers()
        {
            var result = customerTableDataGateway.GetAll();
            var customers = new List<Customer>();

            foreach (DataRow row in result.Rows)
            {
                customers.Add(CustomerMapper.Map(row));
            }



            return customers;
        }

        public Customer SampleMethodUsingIdentityMap(int id)
        {
            var customer = identityMap.Get(id);

            if(customer is not null)
            {
                var result = customerTableDataGateway.GetById(id);
                customer = CustomerMapper.Map(result.Rows[0]); 
                identityMap.Add(customer);
            }  

            return customer;
        }
    }
}
