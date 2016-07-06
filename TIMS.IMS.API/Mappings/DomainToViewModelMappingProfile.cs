using AutoMapper;
using TIMS.IMS.Entities;
using TIMS.IMS.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TIMS.IMS.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<HardwareType, HardwareTypeViewModel>();
            
        }
    }
}