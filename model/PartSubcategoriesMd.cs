using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class PartSubcategoriesMd
    {
        public PartSubcategoriesMd()
        {
            PartsMd = new HashSet<PartsMd>();
        }

        public int PartSubcategoryId { get; set; }
        public string PartSubcategoryName { get; set; }

        public virtual ICollection<PartsMd> PartsMd { get; set; }
    }
}
