using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp.PM_Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public float CommissionFee { get; set; }
        public bool IsOwner { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
