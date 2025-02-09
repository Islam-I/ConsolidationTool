﻿using System.ComponentModel.DataAnnotations;

namespace ConsolidationTool.Service.Helpers
{
    public class AddRoleModel
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string Role { get; set; }
    }
}