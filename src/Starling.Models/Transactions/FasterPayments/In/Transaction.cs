namespace Starling.Models.Transactions.FasterPayments.In
{
    public class Transaction
    {
        public SendingContactAccount SendingContactAccount { get; set; }
        public string SendingContactAccountId { get; set; }
        public string SendingContactId { get; set; }
    }
}