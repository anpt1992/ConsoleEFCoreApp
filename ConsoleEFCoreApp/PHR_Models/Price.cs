using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp.PHR_Models
{
    public partial class Price
    {
        public int Id { get; set; }
        public long ProductId { get; set; }
        public long Value { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Product Product { get; set; }
    }
}
