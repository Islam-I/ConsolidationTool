using System;
using System.Collections.Generic;

namespace ConsolidationTool.Data.DBModels
{
    public partial class OrganizationTbl
    {
        public long OrganizationId { get; set; }
        public string? OrganizationEnName { get; set; }
        public string? OrganizationArName { get; set; }
        public string? CustomerCode { get; set; }
        public string? PropertiesNames { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? NoOfProducts { get; set; }
        public string? SysLicenseTypeIds { get; set; }
        public bool? MultiPropertyYn { get; set; }
        public bool? UnlimitedYn { get; set; }
        public string? LicenseCode { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
