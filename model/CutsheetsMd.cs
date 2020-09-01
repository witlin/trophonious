using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class CutsheetsMd
    {
        public CutsheetsMd()
        {
            PartsMd = new HashSet<PartsMd>();
        }

        public int CutsheetId { get; set; }
        public string FilePath { get; set; }

        public virtual ICollection<PartsMd> PartsMd { get; set; }
    }
}
