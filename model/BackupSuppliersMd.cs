using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class BackupSuppliersMd
    {
        public BackupSuppliersMd()
        {
            PartsMd = new HashSet<PartsMd>();
        }

        public int BackupSupplierId { get; set; }
        public string BackupSupplierName { get; set; }

        public virtual ICollection<PartsMd> PartsMd { get; set; }
    }
}
