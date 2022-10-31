namespace csfd.BussinessLayer.Models
{
    public class Payment : IEntity
    {
        public int Id { get; set; }
        public double Amount { get; set; }
    }
}
