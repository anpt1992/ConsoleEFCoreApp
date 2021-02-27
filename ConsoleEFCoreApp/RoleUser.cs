using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp
{
    public partial class RoleUser
    {
        public uint UserId { get; set; }
        public uint RoleId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
