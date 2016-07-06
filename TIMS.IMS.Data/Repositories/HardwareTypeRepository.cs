using TIMS.IMS.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIMS.IMS.Entities;

namespace TIMS.IMS.Data.Repositories
{
    public class HardwareTypeRepository : RepositoryBase<HardwareType>, IHardwareTypeRepository
    {
        public HardwareTypeRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public HardwareType GetHardwareTypeByName(string Name)
        {
            var hardwareType = this.DbContext.HardwareType.Where(c => c.Description == Name).FirstOrDefault();

            return hardwareType;
        }

        public override void Update(HardwareType entity)
        {
            entity.UpdateDateTime = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IHardwareTypeRepository : IRepository<HardwareType>
    {
        HardwareType GetHardwareTypeByName(string Name);
    }
}
