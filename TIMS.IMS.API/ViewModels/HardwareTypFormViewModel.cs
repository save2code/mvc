using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TIMS.IMS.Web.ViewModels
{
    public class HardwareTypeFormViewModel
    {
        public int ID { get; set; }


        public string Description { get; set; }

        public DateTime InsertDateTime { get; set; }

        public short? UpdatedID { get; set; }

        public DateTime? UpdateDateTime { get; set; }
    }
}