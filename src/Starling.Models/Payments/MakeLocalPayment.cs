namespace Starling.Models.Payments
{
    public class MakeLocalPayment
    {
        public string DestinationAccountUid { get; set; }
        public Payment Payment { get; set; }
        public string Reference { get; set; }
    }
}