using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Core.Dtos
{
    public class ApplicationUserDto
    {
        public string UserName { get; set; }
        public string? FirstName { get; set; }
        public string Password { get; set; }
    }
}
