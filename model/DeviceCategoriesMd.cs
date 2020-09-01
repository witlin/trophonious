using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class DeviceCategoriesMd
    {
        public DeviceCategoriesMd()
        {
            DeviceTypesMd = new HashSet<DeviceTypesMd>();
        }

        public int DeviceCategoryId { get; set; }
        public string DeviceCategory { get; set; }

        public virtual ICollection<DeviceTypesMd> DeviceTypesMd { get; set; }
    }
}
