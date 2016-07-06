namespace TIMS.IMS.Entities
{
    public class Inventory
    {
        public AssetInfo AssetInformation { get; set; }
        public BillingInfo BillingInformation { get; set; }
        public LocationInfo LocationInformation { get; set; }
    }
}
