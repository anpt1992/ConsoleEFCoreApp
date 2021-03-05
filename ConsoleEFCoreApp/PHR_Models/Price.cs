using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp.PHR_Models
{
    public partial class Price
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long Value { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Account CreatedByNavigation { get; set; }
        public virtual Product Product { get; set; }
    }
}
