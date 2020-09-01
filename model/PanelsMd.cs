using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class PanelsMd
    {
        public int PanelId { get; set; }
        public string PanelNumber { get; set; }
        public decimal ProductRevisionNumber { get; set; }
        public DateTimeOffset LastModified { get; set; }
        public string LastModifiedBy { get; set; }
        public string PanelDescription { get; set; }
        public string ImageFolderPath { get; set; }
        public string DwgfilePath { get; set; }
        public string SheetMgrFilePath { get; set; }
        public string PdffilePath { get; set; }
        public int? PanelCategoryId { get; set; }
        public int? PanelSubcategoryId { get; set; }
        public int? PanelDwgindexId { get; set; }
        public int? PanelBomId { get; set; }

        public virtual PanelBomMd PanelBom { get; set; }
        public virtual PanelCategoriesMd PanelCategory { get; set; }
        public virtual PanelDwgindexMd PanelDwgindex { get; set; }
        public virtual PanelSubcategoriesMd PanelSubcategory { get; set; }
    }
}
