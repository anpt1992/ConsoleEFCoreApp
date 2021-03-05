using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp.PM_Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Price { get; set; }
        public int AddressId { get; set; }
        public string Area { get; set; }
        public string AreaCalc { get; set; }
        public int StructureId { get; set; }
        public int AdvertiseId { get; set; }
        public int TypeId { get; set; }
        public int DirectionId { get; set; }
        public int StatusId { get; set; }
        public string GoogleDriveUrl { get; set; }
        public int ContactId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }

        public virtual Address Address { get; set; }
    }
}
