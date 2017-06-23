namespace Starling.Models.Transactions.FasterPayments.Out
{
    public class Transaction
    {
        public ReceivingContactAccount ReceivingContactAccount { get; set; }
        public string ReceivingContactAccountId { get; set; }
        public string ReceivingContactId { get; set; }
    }
}