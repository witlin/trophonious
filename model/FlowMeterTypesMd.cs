using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class FlowMeterTypesMd
    {
        public int FlowMeterTypeId { get; set; }
        public string MeterService { get; set; }
        public string MeterRange { get; set; }
        public short PipeSizeInches { get; set; }
        public int? PipeMaterialId { get; set; }
        public int? UnitId { get; set; }
        public int? PartId { get; set; }

        public virtual PartsMd Part { get; set; }
        public virtual PipeMaterialTypesMd PipeMaterial { get; set; }
        public virtual EngineeringUnitTypesMd Unit { get; set; }
    }
}
