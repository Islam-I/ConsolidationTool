using System;
using System.Collections.Generic;

namespace ConsolidationTool.Data.DBModels
{
    public partial class PropertyCategorizationTbl
    {
        public long PropertyCategorizationId { get; set; }
        public long? PropertyId { get; set; }
        public long? CategorizationId { get; set; }
        public long? CategorizationDetailsId { get; set; }

        public virtual CategorizationTbl? Categorization { get; set; }
        public virtual CategorizationDetailsTbl? CategorizationDetails { get; set; }
        public virtual PropertyTbl? Property { get; set; }
    }
}
