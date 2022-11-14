using csfd.DataLayer.DbMock;

namespace csfd.BussinessLayer.TransactionScripts
{
    public class CalculateRevenue
    {
        private readonly TransactionGateway _transactionsGateway;

        public CalculateRevenue()
        {
            _transactionsGateway = new TransactionGateway();
        }

        public double Calculate()
        {
            var incomming = _transactionsGateway.GetIncommingTransactions();

            var outgoing = _transactionsGateway.GetOutgoingTransactions();


            //double e = 0;
            //foreach (var t in incomming)
            //{
            //    e += t.Amount;
            //}

            // Tax removal
            var earned = incomming.Sum(x => x.Amount) * 0.85;

            var spent = outgoing.Sum(x => x.Amount);

            return earned - spent;
        }
    }
}
