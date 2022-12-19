using System;
using System.Collections.Generic;

namespace ConsolidationTool.Data.DBModels
{
    public partial class CategorizationTbl
    {
        public CategorizationTbl()
        {
            CategorizationDetailsTbls = new HashSet<CategorizationDetailsTbl>();
            PropertyCategorizationTbls = new HashSet<PropertyCategorizationTbl>();
        }

        public long CategorizationId { get; set; }
        public string? CategorizationCode { get; set; }
        public string? CategorizationEnName { get; set; }
        public string? CategorizationArName { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<CategorizationDetailsTbl> CategorizationDetailsTbls { get; set; }
        public virtual ICollection<PropertyCategorizationTbl> PropertyCategorizationTbls { get; set; }
    }
}
