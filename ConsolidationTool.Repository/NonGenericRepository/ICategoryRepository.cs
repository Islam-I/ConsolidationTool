using ConsolidationTool.Data.Models;
using ConsolidationTool.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Repository.NonGenericRepository
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {

    }
}
