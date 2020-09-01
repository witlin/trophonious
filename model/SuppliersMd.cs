using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class SuppliersMd
    {
        public SuppliersMd()
        {
            PartsMd = new HashSet<PartsMd>();
        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }

        public virtual ICollection<PartsMd> PartsMd { get; set; }
    }
}
