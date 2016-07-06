using TIMS.IMS.Data.Infrastructure;
using TIMS.IMS.Data.Repositories;
using TIMS.IMS.Entities;
using System.Collections.Generic;
using System.Linq;

namespace TIMS.IMS.Services
{
    // operations you want to expose
    public interface IHardwareTypeService
    {
        IEnumerable<HardwareType> GetHardwareType(string name = null);
        HardwareType GetHardwareType(int id);
        HardwareType GetHardwareTypeByName(string name);
        void CreateHardwareType(HardwareType hardwareType);
        void SaveHardwareType();

    }

    public class HardwareTypeService : IHardwareTypeService
    {
        private readonly IHardwareTypeRepository hardwareTypeRepository;
        private readonly IUnitOfWork unitOfWork;

        public HardwareTypeService(IHardwareTypeRepository hardwareTypeRepository, IUnitOfWork unitOfWork)
        {
            this.hardwareTypeRepository = hardwareTypeRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IInventoryService Members

        public IEnumerable<HardwareType> GetHardwareType(string name = null)
        {
            if (string.IsNullOrEmpty(name))
                return hardwareTypeRepository.GetAll();
            else
                return hardwareTypeRepository.GetAll().Where(c => c.Description == name);
        }

        public HardwareType GetHardwareType(int id)
        {
            var hardwareType = hardwareTypeRepository.GetById(id);
            return hardwareType;
        }

        public HardwareType GetHardwareTypeByName(string name)
        {
            var category = hardwareTypeRepository.GetHardwareTypeByName(name);
            return category;
        }

        public void CreateHardwareType(HardwareType hardwareType)
        {
            hardwareTypeRepository.Add(hardwareType);
        }

        public void SaveHardwareType()
        {
            //Commit of unitofwork
            unitOfWork.Commit();
        }

        #endregion
    }
}
