namespace Starling.Models.Transactions.FasterPayments.In
{
    public class ListTransactions
    {
        public NextPage NextPage { get; set; }
        public Embedded Embedded { get; set; }
        public Links Links { get; set; }
    }
}