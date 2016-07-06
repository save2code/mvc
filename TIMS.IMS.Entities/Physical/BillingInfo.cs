namespace TIMS.IMS.Entities
{
    public class BillingInfo
    {
        public string MaintPO { get; set; }
        public string WarrStartDt { get; set; }
        public string WarrExpDt { get; set; }
        public string DeliveryDt { get; set; }
        public string HWCost { get; set; }
        public string MaintCost { get; set; }
        public string SupportCost { get; set; }
        public string DecommissionedDt { get; set; }
        public string DisposalReqDt { get; set; }
        public string DataCenterRemovalDt { get; set; }
    }
}
