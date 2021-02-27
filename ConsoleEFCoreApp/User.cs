using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp
{
    public partial class User
    {
        public uint Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Permissions { get; set; }
        public int RoleId { get; set; }
        public int DepartmentId { get; set; }
        public DateTime? LastLogin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int CreatedBy { get; set; }
    }
}
