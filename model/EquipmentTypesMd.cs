using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class EquipmentTypesMd
    {
        public int EquipmentTypeId { get; set; }
        public string EquipmentName { get; set; }
        public int EquipmentCategoryId { get; set; }
        public int EquipmentSubcategoryId { get; set; }

        public virtual EquipmentCategoriesMd EquipmentCategory { get; set; }
        public virtual EquipmentSubcategoriesMd EquipmentSubcategory { get; set; }
    }
}
