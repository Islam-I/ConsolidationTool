using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Core.Dtos
{
    public class PropertyDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int SubCategoryId { get; set; }
    }
}
