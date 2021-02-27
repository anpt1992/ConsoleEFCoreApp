using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp.PM_Models
{
    public partial class Price
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string Price1 { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
