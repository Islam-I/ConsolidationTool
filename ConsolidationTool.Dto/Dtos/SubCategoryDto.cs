using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Core.Dtos
{
    public class SubCategoryDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
    }
}
