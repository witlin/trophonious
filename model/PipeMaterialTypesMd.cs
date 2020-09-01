using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class PipeMaterialTypesMd
    {
        public PipeMaterialTypesMd()
        {
            FlowMeterTypesMd = new HashSet<FlowMeterTypesMd>();
        }

        public int MaterialTypeId { get; set; }
        public string MaterialType { get; set; }

        public virtual ICollection<FlowMeterTypesMd> FlowMeterTypesMd { get; set; }
    }
}
