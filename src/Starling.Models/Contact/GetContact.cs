namespace Starling.Models.Contact
{
    public class GetContact
    {
        public Accounts Accounts { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public Photo Photo { get; set; }
        public Self Self { get; set; }
    }
}