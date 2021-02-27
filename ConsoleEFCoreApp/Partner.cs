using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp
{
    public partial class Partner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameShort { get; set; }
        public string Address { get; set; }
        public DateTime? DateContact { get; set; }
        public string Phone { get; set; }
        public string Director { get; set; }
        public string DirectorAddress { get; set; }
        public string DirectorEmail { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Fanpage { get; set; }
        public string Business { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public int CreatedBy { get; set; }
        public string Projects { get; set; }
    }
}
