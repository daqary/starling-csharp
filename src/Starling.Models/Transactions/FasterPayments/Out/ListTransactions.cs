using Newtonsoft.Json;

namespace Starling.Models.Transactions.FasterPayments.Out
{
    public class ListTransactions
    {
        public NextPage NextPage { get; set; }
        [JsonProperty(PropertyName = "_embedded")] public Embedded Embedded { get; set; }
        [JsonProperty(PropertyName = "_links")] public Links Links { get; set; }
    }
}