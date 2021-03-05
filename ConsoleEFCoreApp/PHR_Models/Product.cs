using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp.PHR_Models
{
    public partial class Product
    {
        public Product()
        {
            Notes = new HashSet<Note>();
            Prices = new HashSet<Price>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string HouseNumber { get; set; }
        public int StreetId { get; set; }
        public int WardId { get; set; }
        public int DistrictId { get; set; }
        public string Area { get; set; }
        public int AreaCalc { get; set; }
        public int StructureId { get; set; }
        public int AdvertiseId { get; set; }
        public int CategoryId { get; set; }
        public int DirectionId { get; set; }
        public int StatusId { get; set; }
        public string GoogleDriveUrl { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public float CommissionFee { get; set; }
        public bool IsOwner { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Advertise Advertise { get; set; }
        public virtual Category Category { get; set; }
        public virtual Account CreatedByNavigation { get; set; }
        public virtual Direction Direction { get; set; }
        public virtual District District { get; set; }
        public virtual Status Status { get; set; }
        public virtual Street Street { get; set; }
        public virtual Structure Structure { get; set; }
        public virtual Ward Ward { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Price> Prices { get; set; }
    }
}
