namespace csfd.DataLayer.DbMock
{
    public class TransactionDTO
    {
        public int Id { get; set; }

        public double Amount { get; set; }

        public TransactionDirection Direction { get; set; }
    }

    public enum TransactionDirection
    {
        In,
        Out
    }
}
