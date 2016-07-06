namespace TIMS.IMS.Entities
{
    using System;
    
    public partial class MemorySize
    {
         

        public short ID { get; set; }

        
        public string Name { get; set; }

        public DateTime InsertDateTime { get; set; }

        public short? UpdatedID { get; set; }

        public DateTime? UpdateDateTime { get; set; }

        
    }
}
