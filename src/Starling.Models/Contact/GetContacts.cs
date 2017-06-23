using Newtonsoft.Json;

namespace Starling.Models.Contact
{
    public class GetContacts
    {
        public Self Self { get; set; }
        [JsonProperty(PropertyName = "_embedded")] public Embedded Embedded { get; set; }
        [JsonProperty(PropertyName = "_links")] public Links Links { get; set; }
    }
}