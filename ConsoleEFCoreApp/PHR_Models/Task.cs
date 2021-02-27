using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp.PHR_Models
{
    public partial class Task
    {
        public Task()
        {
            Notes = new HashSet<Note>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
    }
}
