using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Data.Models
{
    public class Property : CommonProperties
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int SubCategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; }
    }
}
