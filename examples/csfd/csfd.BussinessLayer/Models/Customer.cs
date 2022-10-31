using csfd.BussinessLayer.Mapper;
using csfd.DataLayer;
using System.Data;

namespace csfd.BussinessLayer.Models
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        private Lazy<List<Payment>> _payments;

        public List<Payment> Payments 
        { 
            get
            {
                return _payments.Value; 
            }
        }

        public Customer()
        {
            _payments = new Lazy<List<Payment>>(() => GetPayments());
        }

        private List<Payment> GetPayments()
        {
            var payments = new List<Payment>();
            var tdg = new PaymentTableDataGateway();
            var result = tdg.GetByCustomerId(Id);

            foreach (DataRow row in result.Rows)
            {
                payments.Add(PaymentMapper.Map(row));
            }

            return payments;
        }
    }
}
