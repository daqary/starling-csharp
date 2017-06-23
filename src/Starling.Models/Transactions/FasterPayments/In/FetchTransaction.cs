namespace Starling.Models.Transactions.FasterPayments.In
{
    public class FetchTransaction
    {
        public SendingContactAccount SendingContactAccount { get; set; }
        public string SendingContactAccountId { get; set; }
        public string SendingContactId { get; set; }
    }
}