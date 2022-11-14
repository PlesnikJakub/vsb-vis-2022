namespace csfd.DataLayer.DbMock
{
    public class TransactionGateway
    {
        // InMemory implementation
        public static List<TransactionDTO> Transactions { get; set; } = new List<TransactionDTO> {
            new TransactionDTO
            {
                Id = 1,
                Amount = 150,
                Direction = TransactionDirection.In,
            },
            new TransactionDTO
            {
                Id = 2,
                Amount = 200,
                Direction = TransactionDirection.In,
            },
            new TransactionDTO
            {
                Id = 2,
                Amount = 100,
                Direction = TransactionDirection.Out,
            },
        };

        public IEnumerable<TransactionDTO> GetIncommingTransactions()
        {
            // this could be easily replaced by SQL call
            // we would need to use some mapper though
            // to map datatable to DTO
            return Transactions.Where(x => x.Direction == TransactionDirection.In);
        }

        public IEnumerable<TransactionDTO> GetOutgoingTransactions()
        {
            // equivalent to 
            //var result = new List<TransactionDTO>();
            //foreach (var transaction in Transactions)
            //{
            //    if (transaction.Direction == TransactionDirection.Out)
            //    {
            //        result.Add(transaction);
            //    }
            //}
            //return result;

            return Transactions.Where(x => x.Direction == TransactionDirection.Out);
        }
    }
}
