using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class SubmittalSectionCategoriesMd
    {
        public SubmittalSectionCategoriesMd()
        {
            SubmittalSectionsMd = new HashSet<SubmittalSectionsMd>();
        }

        public int SubmittalSectionCategoryId { get; set; }
        public string SubmittalSectionCategory { get; set; }

        public virtual ICollection<SubmittalSectionsMd> SubmittalSectionsMd { get; set; }
    }
}
