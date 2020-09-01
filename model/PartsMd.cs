using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class PartsMd
    {
        public PartsMd()
        {
            DeviceTypesMd = new HashSet<DeviceTypesMd>();
            FlowMeterTypesMd = new HashSet<FlowMeterTypesMd>();
            PanelBomMd = new HashSet<PanelBomMd>();
            ValveTypesMd = new HashSet<ValveTypesMd>();
        }

        public int PartId { get; set; }
        public string PartDescription { get; set; }
        public string NameTag { get; set; }
        public decimal UnitPrice { get; set; }
        public int? ManufacturerId { get; set; }
        public int? CutsheetId { get; set; }
        public int? SupplierId { get; set; }
        public int? BackupSupplierId { get; set; }
        public int? PartCategoryId { get; set; }
        public int? PartSubcategoryId { get; set; }

        public virtual BackupSuppliersMd BackupSupplier { get; set; }
        public virtual CutsheetsMd Cutsheet { get; set; }
        public virtual ManufacturersMd Manufacturer { get; set; }
        public virtual PartCategoriesMd PartCategory { get; set; }
        public virtual PartSubcategoriesMd PartSubcategory { get; set; }
        public virtual SuppliersMd Supplier { get; set; }
        public virtual ICollection<DeviceTypesMd> DeviceTypesMd { get; set; }
        public virtual ICollection<FlowMeterTypesMd> FlowMeterTypesMd { get; set; }
        public virtual ICollection<PanelBomMd> PanelBomMd { get; set; }
        public virtual ICollection<ValveTypesMd> ValveTypesMd { get; set; }
    }
}
