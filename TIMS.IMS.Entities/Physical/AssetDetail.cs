namespace TIMS.IMS.Entities
{
    using System;

    public partial class AssetDetail
    {
        public int ID { get; set; }


        public string SerialNumber { get; set; }


        public string HardwarePurchaseOrderNumber { get; set; }

        public string Manufacturer { get; set; }


        public string Model { get; set; }

        public short? HardwareTypeID { get; set; }

        public short? DiskCapacityID { get; set; }

        public short? MemorySizeID { get; set; }

        public short? NumberOfCPUsID { get; set; }

        public short? NumberOfCPUCoresID { get; set; }

        public short? NodesID { get; set; }

        public bool IsAvailableForUse { get; set; }

        public short? AssetCategoryID { get; set; }


        public string DeviceName { get; set; }


        public string MaintenanceContractORSiteNumber { get; set; }

        public int ProjectID { get; set; }


        public string MaintenancePurchaseOrderNumber { get; set; }


        public DateTime? WarrantyStartDate { get; set; }


        public DateTime? WarrantyExpirationDate { get; set; }


        public DateTime? DeliveryDate { get; set; }


        public decimal HardwareCost { get; set; }


        public decimal? MaintenanceCost { get; set; }


        public decimal? SupportCost { get; set; }

        public short DataCenterID { get; set; }

        public short? RackNumberID { get; set; }

        public short? SlotID { get; set; }

        public short? BladeChassisID { get; set; }

        public short EnvironmentID { get; set; }

        public bool IsDecommissioned { get; set; }


        public DateTime? DecommissionedDate { get; set; }


        public DateTime? DisposalRequestDate { get; set; }


        public DateTime? DataCenterRemovalDate { get; set; }

        public DateTime InsertDateTime { get; set; }

        public int? UpdatedID { get; set; }

        public DateTime? UpdateDateTime { get; set; }

        public short? StatusID { get; set; }

        public virtual AssetCategory AssetCategory { get; set; }

        public virtual BladeChassi BladeChassi { get; set; }

        public virtual DataCenter DataCenter { get; set; }

        public virtual DiskCapacity DiskCapacity { get; set; }

        public virtual Environment Environment { get; set; }

        public virtual HardwareType HardwareType { get; set; }

        public virtual MemorySize MemorySize { get; set; }

        public virtual Node Node { get; set; }

        public virtual NumberOfCPUCore NumberOfCPUCore { get; set; }

        public virtual NumberOfCPU NumberOfCPU { get; set; }

        public virtual Project Project { get; set; }

        public virtual RackNumber RackNumber { get; set; }

        public virtual Slot Slot { get; set; }

        public virtual Status Status { get; set; }
    }
}
