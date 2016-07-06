using TIMS.IMS.Data.Configuration;
using TIMS.IMS.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMS.IMS.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("TIMSIMS_DBContext") { }

        public DbSet<HardwareType> HardwareType { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new HardwareTypeConfiguration());
        }
    }
}
