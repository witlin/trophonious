using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class DocumentTemplatesMd
    {
        public int TemplateId { get; set; }
        public string FileType { get; set; }
        public short RevisionNumber { get; set; }
        public string FilePath { get; set; }
        public DateTimeOffset LastModified { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
