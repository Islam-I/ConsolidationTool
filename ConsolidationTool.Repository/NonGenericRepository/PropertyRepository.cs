using ConsolidationTool.Data.DatabaseContext;
using ConsolidationTool.Data.Models;
using ConsolidationTool.Repository.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Repository.NonGenericRepository
{
    public class PropertyRepository : BaseRepository<Property>, IPropertyRepository {
        private readonly TestDBContext _context;
        public PropertyRepository(TestDBContext context) : base(context) 
        {
            _context = context;
        }
    }
}
