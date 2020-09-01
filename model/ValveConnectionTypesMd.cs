using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class ValveConnectionTypesMd
    {
        public ValveConnectionTypesMd()
        {
            ValveTypesMd = new HashSet<ValveTypesMd>();
        }

        public int ValveConnectionTypeId { get; set; }
        public string ValveConnectionType { get; set; }

        public virtual ICollection<ValveTypesMd> ValveTypesMd { get; set; }
    }
}
