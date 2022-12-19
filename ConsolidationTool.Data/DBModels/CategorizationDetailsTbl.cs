using System;
using System.Collections.Generic;

namespace ConsolidationTool.Data.DBModels
{
    public partial class CategorizationDetailsTbl
    {
        public CategorizationDetailsTbl()
        {
            PropertyCategorizationTbls = new HashSet<PropertyCategorizationTbl>();
        }

        public long CategorizationDetailsId { get; set; }
        public long? CategorizationId { get; set; }
        public string? CategorizationDetailsCode { get; set; }
        public string? CategorizationDetailsEnName { get; set; }
        public string? CategorizationDetailsArName { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual CategorizationTbl? Categorization { get; set; }
        public virtual ICollection<PropertyCategorizationTbl> PropertyCategorizationTbls { get; set; }
    }
}
