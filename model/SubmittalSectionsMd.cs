using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class SubmittalSectionsMd
    {
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public short SectionNumber { get; set; }
        public string FileType { get; set; }
        public int? CategoryId { get; set; }

        public virtual SubmittalSectionCategoriesMd Category { get; set; }
    }
}
