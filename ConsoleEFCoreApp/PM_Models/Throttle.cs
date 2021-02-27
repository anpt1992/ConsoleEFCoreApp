using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp.PM_Models
{
    public partial class Throttle
    {
        public uint Id { get; set; }
        public uint? UserId { get; set; }
        public string Type { get; set; }
        public string Ip { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
