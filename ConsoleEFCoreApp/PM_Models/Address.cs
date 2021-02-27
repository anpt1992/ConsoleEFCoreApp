using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp.PM_Models
{
    public partial class Address
    {
        public int Id { get; set; }
        public string HouseNumber { get; set; }
        public int? StreetId { get; set; }
        public int? WardId { get; set; }
        public int? DistrictId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
