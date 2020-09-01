using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class ManufacturersMd
    {
        public ManufacturersMd()
        {
            PartsMd = new HashSet<PartsMd>();
        }

        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }

        public virtual ICollection<PartsMd> PartsMd { get; set; }
    }
}
