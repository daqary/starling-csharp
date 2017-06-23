namespace Starling.Models.Accounts
{
    public class Account
    {
        public string Bic { get; set; }
        public Card Card { get; set; }
        public string CreatedAt { get; set; }
        public string Currency { get; set; }
        public Customer Customer { get; set; }
        public string Iban { get; set; }
        public string Id { get; set; }
        public Mandates Mandates { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public Payees Payees { get; set; }
        public string SortCode { get; set; }
        public Transactions Transactions { get; set; }
    }
}