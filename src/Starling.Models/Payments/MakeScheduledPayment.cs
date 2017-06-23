namespace Starling.Models.Payments
{
    public class MakeScheduledPayment
    {
        public string DestinationAccountUid { get; set; }
        public Payment Payment { get; set; }
        public RecurrenceRule RecurrenceRule { get; set; }
        public string Reference { get; set; }
    }
}