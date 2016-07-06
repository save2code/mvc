namespace TIMS.IMS.Entities
{
    using System;
    

    public partial class PhysicalInventory : DbContext
    {
        public PhysicalInventory()
            : base("name=TIMS_IMS")
        {
        }

        public virtual DbSet<AssetCategory> AssetCategories { get; set; }
        public virtual DbSet<AssetDetail> AssetDetails { get; set; }
        public virtual DbSet<BladeChassi> BladeChassis { get; set; }
        public virtual DbSet<DataCenter> DataCenters { get; set; }
        public virtual DbSet<DiskCapacity> DiskCapacities { get; set; }
        public virtual DbSet<Environment> Environments { get; set; }
        public virtual DbSet<HardwareType> HardwareTypes { get; set; }
        public virtual DbSet<MemorySize> MemorySizes { get; set; }
        public virtual DbSet<Node> Nodes { get; set; }
        public virtual DbSet<NumberOfCPUCore> NumberOfCPUCores { get; set; }
        public virtual DbSet<NumberOfCPU> NumberOfCPUs { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<RackNumber> RackNumbers { get; set; }
        public virtual DbSet<Slot> Slots { get; set; }
        public virtual DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssetDetail>()
                .Property(e => e.HardwareCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AssetDetail>()
                .Property(e => e.MaintenanceCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AssetDetail>()
                .Property(e => e.SupportCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BladeChassi>()
                .HasMany(e => e.AssetDetails)
                .WithOptional(e => e.BladeChassi)
                .HasForeignKey(e => e.BladeChassisID);

            modelBuilder.Entity<DataCenter>()
                .HasMany(e => e.AssetDetails)
                .WithRequired(e => e.DataCenter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Environment>()
                .HasMany(e => e.AssetDetails)
                .WithRequired(e => e.Environment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Node>()
                .HasMany(e => e.AssetDetails)
                .WithOptional(e => e.Node)
                .HasForeignKey(e => e.NodesID);

            modelBuilder.Entity<NumberOfCPUCore>()
                .HasMany(e => e.AssetDetails)
                .WithOptional(e => e.NumberOfCPUCore)
                .HasForeignKey(e => e.NumberOfCPUCoresID);

            modelBuilder.Entity<NumberOfCPU>()
                .HasMany(e => e.AssetDetails)
                .WithOptional(e => e.NumberOfCPU)
                .HasForeignKey(e => e.NumberOfCPUsID);

            modelBuilder.Entity<Project>()
                .HasMany(e => e.AssetDetails)
                .WithRequired(e => e.Project)
                .WillCascadeOnDelete(false);
        }
    }
}
