using csfd.DataLayer;
using System.Data;

namespace csfd.BussinessLayer
{
    public class CustomerService
    {
        private readonly CustomerTableDataGateway customerTableDataGateway;

        public CustomerService()
        {
            customerTableDataGateway = new CustomerTableDataGateway();
        }

        public List<Customer> GetAllCustomers()
        {
            var result = customerTableDataGateway.GetAll();
            var customers = new List<Customer>();

            foreach (DataRow row in result.Rows)
            {
                customers.Add(Customer.BuildFrom(row));
            }

            return customers;  
        }
    }
}
