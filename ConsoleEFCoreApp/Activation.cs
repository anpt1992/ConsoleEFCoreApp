using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp
{
    public partial class Activation
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public string Code { get; set; }
        public bool Completed { get; set; }
        public DateTime? CompletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
