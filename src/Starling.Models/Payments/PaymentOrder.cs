using Starling.Models.Accounts;

namespace Starling.Models.Payments
{
    public class PaymentOrder
    {
        public double Amount { get; set; }
        public string CancelledAt { get; set; }
        public string Currency { get; set; }
        public string EndDate { get; set; }
        public string LastDate { get; set; }
        public Mandate Mandate { get; set; }
        public string MandateId { get; set; }
        public string NextDate { get; set; }
        public string PaymentOrderId { get; set; }
        public string PaymentType { get; set; }
        public ReceivingContactAccount ReceivingContactAccount { get; set; }
        public string ReceivingContactAccountId { get; set; }
        public string RecipientName { get; set; }
        public RecurrenceRule RecurrenceRule { get; set; }
        public string Reference { get; set; }
        public string StartDate { get; set; }
    }
}