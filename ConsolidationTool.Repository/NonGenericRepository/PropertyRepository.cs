using ConsolidationTool.Data.DatabaseContext;
using ConsolidationTool.Data.Models;
using ConsolidationTool.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Repository.NonGenericRepository
{
    public class PropertyRepository : GenericRepository<Property>, IPropertyRepository { 
        public PropertyRepository(TestDBContext context) : base(context) { }
    }
}
