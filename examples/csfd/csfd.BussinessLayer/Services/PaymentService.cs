using csfd.BussinessLayer.Dto;
using csfd.BussinessLayer.Mapper;
using csfd.BussinessLayer.Models;
using csfd.DataLayer;
using System.Data;

namespace csfd.BussinessLayer.Services
{
    public class PaymentService
    {
        private readonly PaymentTableDataGateway _paymentTableDataGateway;
        public PaymentService()
        {
            _paymentTableDataGateway = new PaymentTableDataGateway();
        }

        public CutomerPaymentsDTO GetPaymentsForCustomer(int customerId)
        {
            var payments = Map(_paymentTableDataGateway.GetByCustomerId(customerId));

            var totalAmount = payments.Select(x => x.Amount).Sum();
            var totalTax = totalAmount * 0.21;

            return new CutomerPaymentsDTO
            {
                Customer = null,
                Payments = payments,
                PayAmount = totalAmount,
                TaxAmount = totalTax
            };
        }

        private List<Payment> Map(DataTable paymentsTable)
        {
            var payments = new List<Payment>();

            foreach (DataRow row in paymentsTable.Rows)
            {
                payments.Add(PaymentMapper.Map(row));
            }

            return payments;
        }
    }
}
