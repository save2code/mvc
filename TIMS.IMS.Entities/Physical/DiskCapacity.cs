using System;

namespace TIMS.IMS.Entities
{


    public partial class DiskCapacity
    {

        public short ID { get; set; }


        public string Name { get; set; }

        public DateTime InsertDateTime { get; set; }

        public short? UpdatedID { get; set; }

        public DateTime? UpdateDateTime { get; set; }

    }
}
