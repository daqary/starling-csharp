namespace Starling.Models.Merchants
{
    public class MerchantLocation
    {
        public string Address { get; set; }
        public string GooglePlaceId { get; set; }
        public string LocationName { get; set; }
        public int MastercardMerchantCategoryCode { get; set; }
        public Merchant Merchant { get; set; }
        public MerchantLocationUid MerchantLocationUid { get; set; }
        public string MerchantName { get; set; }
        public MerchantUid MerchantUid { get; set; }
        public string PhoneNumber { get; set; }
    }
}