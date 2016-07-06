using AutoMapper;
using TIMS.IMS.Entities;
using TIMS.IMS.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TIMS.IMS.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<HardwareTypeFormViewModel, HardwareType>()
                .ForMember(g => g.ID, map => map.MapFrom(vm => vm.ID))
                .ForMember(g => g.Description, map => map.MapFrom(vm => vm.Description))
                .ForMember(g => g.InsertDateTime, map => map.MapFrom(vm => vm.InsertDateTime))
                .ForMember(g => g.UpdateDateTime, map => map.MapFrom(vm => vm.UpdateDateTime))
                .ForMember(g => g.UpdatedID, map => map.MapFrom(vm => vm.UpdatedID));
        }
    }
}