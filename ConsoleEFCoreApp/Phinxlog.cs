using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp
{
    public partial class Phinxlog
    {
        public long Version { get; set; }
        public string MigrationName { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool Breakpoint { get; set; }
    }
}
