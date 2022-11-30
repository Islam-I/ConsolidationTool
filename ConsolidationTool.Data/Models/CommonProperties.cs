using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Data.Models
{
    public class CommonProperties
    {
        public string UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public string InsertedAt { get; set; }
        public int InsertedBy { get; set; }
        public bool IsDeleted_YN { get; set; }
        public int FormID { get; set; }
    }
}
