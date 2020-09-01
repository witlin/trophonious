using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class DeviceSubcategoriesMd
    {
        public DeviceSubcategoriesMd()
        {
            DeviceTypesMd = new HashSet<DeviceTypesMd>();
        }

        public int DeviceSubcategoryId { get; set; }
        public string DeviceSubcategory { get; set; }

        public virtual ICollection<DeviceTypesMd> DeviceTypesMd { get; set; }
    }
}
