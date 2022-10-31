using csfd.BussinessLayer.Models;
using System.Data;

namespace csfd.BussinessLayer.Mapper
{
    public static class PaymentMapper
    {
        public static Payment Map(DataRow row)
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
