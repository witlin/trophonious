using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class PanelDwgindexMd
    {
        public PanelDwgindexMd()
        {
            PanelsMd = new HashSet<PanelsMd>();
        }

        public int PanelIndexId { get; set; }
        public short SheetNumber { get; set; }
        public string SheetTitle { get; set; }

        public virtual ICollection<PanelsMd> PanelsMd { get; set; }
    }
}
