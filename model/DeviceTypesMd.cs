using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class DeviceTypesMd
    {
        public int DeviceTypeId { get; set; }
        public string TypeName { get; set; }
        public string DeviceDescription { get; set; }
        public int? PartId { get; set; }
        public int? DeviceCategoryId { get; set; }
        public int? DeviceSubcategoryId { get; set; }
        public int? NetworkTypeId { get; set; }

        public virtual DeviceCategoriesMd DeviceCategory { get; set; }
        public virtual DeviceSubcategoriesMd DeviceSubcategory { get; set; }
        public virtual PartsMd Part { get; set; }
    }
}
