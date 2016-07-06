namespace TIMS.IMS.Entities
{
    using System;



    public partial class DataCenter
    {


        public short ID { get; set; }


        public string Description { get; set; }

        public DateTime InsertDateTime { get; set; }

        public short? UpdatedID { get; set; }

        public DateTime? UpdateDateTime { get; set; }

    }
}
