using csfd.DataLayer;
using System.Data;

namespace csfd.BussinessLayer
{
    public class PaymentService
    {
        private readonly PaymentTableDataGateway _paymentTableDataGateway;
        public PaymentService()
        {
            _paymentTableDataGateway = new PaymentTableDataGateway();
        }

        public List<Payment> GetPaymentsForCustomer(int customerId)
        {
            var payments = Map(_paymentTableDataGateway.GetByCustomerId(customerId));

            var count = payments.Count();
            var totalAmount = payments.Select(x => x.Amount).Sum();

            return payments;
        }

        private List<Payment> Map(DataTable paymentsTable)
        {
            var payments = new List<Payment>();

            foreach (DataRow row in paymentsTable.Rows)
            {
                payments.Add(Map(row));
            }

            return payments;
        }

        private Payment Map(DataRow row)
        {
            var id = Convert.ToInt32(row["payment_id"]);
            var amount = Convert.ToDouble(row["amount"]);

            return new Payment
            {
                Id = id,
                Amount = amount
            };
        }
    }
}
