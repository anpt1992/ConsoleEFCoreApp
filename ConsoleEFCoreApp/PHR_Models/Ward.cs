﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEFCoreApp.PHR_Models
{
    public partial class Ward
    {
        public Ward()
        {
            Districtwardstreets = new HashSet<Districtwardstreet>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Districtwardstreet> Districtwardstreets { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
