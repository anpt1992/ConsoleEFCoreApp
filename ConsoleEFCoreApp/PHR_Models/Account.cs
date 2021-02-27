using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp.PHR_Models
{
    public partial class Account
    {
        public Account()
        {
            Notes = new HashSet<Note>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
