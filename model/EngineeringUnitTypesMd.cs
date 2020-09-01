using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class EngineeringUnitTypesMd
    {
        public EngineeringUnitTypesMd()
        {
            FlowMeterTypesMd = new HashSet<FlowMeterTypesMd>();
        }

        public int UnitTypeId { get; set; }
        public string UnitName { get; set; }
        public string Unit { get; set; }

        public virtual ICollection<FlowMeterTypesMd> FlowMeterTypesMd { get; set; }
    }
}
