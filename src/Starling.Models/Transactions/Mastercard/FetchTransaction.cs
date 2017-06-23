namespace Starling.Models.Transactions.Mastercard
{
    public class FetchTransaction
    {
        public string MastercardTransactionMethod { get; set; }
        public Merchant Merchant { get; set; }
        public MerchantId MerchantId { get; set; }
        public MerchantLocation MerchantLocation { get; set; }
        public MerchantLocationId MerchantLocationId { get; set; }
        public double SourceAmount { get; set; }
        public string SourceCurrency { get; set; }
        public string Status { get; set; }
    }
}