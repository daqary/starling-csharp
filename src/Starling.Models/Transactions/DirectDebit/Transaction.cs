namespace Starling.Models.Transactions.DirectDebit
{
    public class Transaction
    {
        public Mandate Mandate { get; set; }
        public string MandateId { get; set; }
        public string Type { get; set; }
    }
}