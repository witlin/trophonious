using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class PartCategoriesMd
    {
        public PartCategoriesMd()
        {
            PartsMd = new HashSet<PartsMd>();
        }

        public int PartCategoryId { get; set; }
        public string PartCategoryName { get; set; }

        public virtual ICollection<PartsMd> PartsMd { get; set; }
    }
}
