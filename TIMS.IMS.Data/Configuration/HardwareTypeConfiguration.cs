using TIMS.IMS.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace TIMS.IMS.Data.Configuration
{
    
    public class HardwareTypeConfiguration : EntityTypeConfiguration<HardwareType>
    {
        public HardwareTypeConfiguration()
        {
            ToTable("HardwareType");
            Property(g => g.Description).IsRequired().HasMaxLength(1000);
            Property(g => g.InsertDateTime).IsRequired();
            
        }
    }
}
