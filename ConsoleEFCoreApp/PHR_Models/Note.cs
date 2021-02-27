using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp.PHR_Models
{
    public partial class Note
    {
        public long Id { get; set; }
        public int TaskId { get; set; }
        public string Detail { get; set; }
        public long ProductId { get; set; }
        public bool IsShow { get; set; }
        public int? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Account CreatedByNavigation { get; set; }
        public virtual Product Product { get; set; }
        public virtual Task Task { get; set; }
    }
}
