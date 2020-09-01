using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class PanelCategoriesMd
    {
        public PanelCategoriesMd()
        {
            PanelsMd = new HashSet<PanelsMd>();
        }

        public int PanelCategoryId { get; set; }
        public string PanelCategory { get; set; }

        public virtual ICollection<PanelsMd> PanelsMd { get; set; }
    }
}
