using csfd.BussinessLayer.Models;

namespace csfd.BussinessLayer.Dto
{
    public class CutomerPaymentsDTO
    {
        public Customer? Customer { get; set; }
        public List<Payment>? Payments { get; set; }
        public double? PayAmount { get; set; }
        public double? TaxAmount { get; set; }
    }
}
