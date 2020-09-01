using System;
using System.Collections.Generic;

namespace trophonious.model
{
    public partial class ProjectsMd
    {
        public int ProjectId { get; set; }
        public string ProjectNumber { get; set; }
        public string FolderPath { get; set; }
        public short NumberOfPhases { get; set; }
        public string ProjectAddress { get; set; }
        public string ProjectCity { get; set; }
        public string ProjectState { get; set; }
        public string ProjectZipCode { get; set; }
        public string ProjectCountry { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectEngineer { get; set; }
        public string AuxiliaryEngineer { get; set; }
        public string SubmittedBy { get; set; }
    }
}
