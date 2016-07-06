using TIMS.IMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TIMS.IMS.Web.ViewModels
{
    public class HardwareTypeViewModel
    {
        public int ID { get; set; }
        public string Description { get; set; }

        public List<HardwareTypeViewModel> HardwareType { get; set; }
    }
}