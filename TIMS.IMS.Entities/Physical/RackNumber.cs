namespace TIMS.IMS.Entities.Physical
{
    using System;

    public partial class RackNumber
    {


        public short ID { get; set; }


        public string Name { get; set; }

        public DateTime InsertDateTime { get; set; }

        public short? UpdatedID { get; set; }

        public DateTime? UpdateDateTime { get; set; }

    }
}
