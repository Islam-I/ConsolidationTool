using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace ConsolidationTool.Data.DBModels
{
    public partial class UserTbl : IdentityUser
    {
        //public long UserId { get; set; }
        //public string? UserName { get; set; }
        public string? UserArName { get; set; }
        public string? UserLoginName { get; set; }
        public string? UserPassword { get; set; }
        public bool? ActiveUserYn { get; set; }
        public bool? DeletedYn { get; set; }
        public string? PropertyIds { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? LastPasswordChanged { get; set; }
        public long? PropertyIdLogChanges { get; set; }
        //public byte[]? Email { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
