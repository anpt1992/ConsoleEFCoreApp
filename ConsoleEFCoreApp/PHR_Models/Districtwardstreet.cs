using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp.PHR_Models
{
    public partial class Districtwardstreet
    {
        public int Id { get; set; }
        public int StreetId { get; set; }
        public int WardId { get; set; }
        public int DistrictId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual District District { get; set; }
        public virtual Street Street { get; set; }
        public virtual Ward Ward { get; set; }
    }
}
