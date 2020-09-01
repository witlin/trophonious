using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class PanelBomMd
    {
        public PanelBomMd()
        {
            PanelsMd = new HashSet<PanelsMd>();
        }

        public int PanelBomId { get; set; }
        public short PartQuantity { get; set; }
        public string ProvidedBy { get; set; }
        public int? PartId { get; set; }

        public virtual PartsMd Part { get; set; }
        public virtual ICollection<PanelsMd> PanelsMd { get; set; }
    }
}
