using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class PanelSubcategoriesMd
    {
        public PanelSubcategoriesMd()
        {
            PanelsMd = new HashSet<PanelsMd>();
        }

        public int PanelSubcategoryId { get; set; }
        public string PanelSubcategory { get; set; }

        public virtual ICollection<PanelsMd> PanelsMd { get; set; }
    }
}
