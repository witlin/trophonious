using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class EquipmentSubcategoriesMd
    {
        public EquipmentSubcategoriesMd()
        {
            EquipmentTypesMd = new HashSet<EquipmentTypesMd>();
        }

        public int EquipmentSubcategoryId { get; set; }
        public string EquipmentSubcategory { get; set; }

        public virtual ICollection<EquipmentTypesMd> EquipmentTypesMd { get; set; }
    }
}
