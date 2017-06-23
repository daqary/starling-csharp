namespace Starling.Models.Contact
{
    public class GetContactAccounts
    {
        public Self Self { get; set; }
        public EmbeddedContactAccounts Embedded { get; set; }
        public ContactAccountLinks Links { get; set; }
    }
}