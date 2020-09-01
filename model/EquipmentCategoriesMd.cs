using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class EquipmentCategoriesMd
    {
        public EquipmentCategoriesMd()
        {
            EquipmentTypesMd = new HashSet<EquipmentTypesMd>();
        }

        public int EquipmentCategoryId { get; set; }
        public string EquipmentCategory { get; set; }

        public virtual ICollection<EquipmentTypesMd> EquipmentTypesMd { get; set; }
    }
}
