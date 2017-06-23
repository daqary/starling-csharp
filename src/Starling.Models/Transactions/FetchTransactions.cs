namespace Starling.Models.Transactions
{
    public class FetchTransactions
    {
        public NextPage NextPage { get; set; }
        public Embedded Embedded { get; set; }
        public Links Links { get; set; }
    }
}