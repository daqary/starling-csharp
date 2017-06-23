namespace Starling.Models.Accounts
{
    public class Balance
    {
        public double AcceptedOverdraft { get; set; }
        public double Amount { get; set; }
        public double AvailableToSpend { get; set; }
        public double ClearedBalance { get; set; }
        public string Currency { get; set; }
        public double EffectiveBalance { get; set; }
        public double PendingTransactions { get; set; }
    }
}