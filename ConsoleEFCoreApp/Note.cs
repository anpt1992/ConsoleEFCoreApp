using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp
{
    public partial class Note
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string Detail { get; set; }
        public string Images { get; set; }
        public int ProductId { get; set; }
        public bool IsShow { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
    }
}
