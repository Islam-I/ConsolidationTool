using System;
using System.Collections.Generic;

namespace ConsolidationTool.Data.DBModels
{
    public partial class PropertyTbl
    {
        public PropertyTbl()
        {
            PropertyCategorizationTbls = new HashSet<PropertyCategorizationTbl>();
        }

        public long PropertyId { get; set; }
        public long? OrganizationId { get; set; }
        public string? PropertyCode { get; set; }
        public string? PropertyEnName { get; set; }
        public string? PropertyArName { get; set; }
        public string? ApiLink { get; set; }
        public string? ApiUsername { get; set; }
        public string? ApiPassword { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<PropertyCategorizationTbl> PropertyCategorizationTbls { get; set; }
    }
}
