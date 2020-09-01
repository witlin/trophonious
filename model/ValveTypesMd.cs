using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class ValveTypesMd
    {
        public int ValveTypeId { get; set; }
        public string ModelNumber { get; set; }
        public string ValveService { get; set; }
        public short ValveSizeInches { get; set; }
        public short PipeSizeInches { get; set; }
        public string BodyPattern { get; set; }
        public short CloseOffPressurePsi { get; set; }
        public string OperatingSpan { get; set; }
        public string ActuatorPartNumber { get; set; }
        public string ActuatorFeedback { get; set; }
        public int? PartId { get; set; }
        public int? ValveConnectionTypeId { get; set; }

        public virtual PartsMd Part { get; set; }
        public virtual ValveConnectionTypesMd ValveConnectionType { get; set; }
    }
}
