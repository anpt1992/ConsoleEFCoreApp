using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp.PM_Models
{
    public partial class Role
    {
        public uint Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Permissions { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
