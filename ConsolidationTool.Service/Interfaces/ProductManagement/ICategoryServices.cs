using ConsolidationTool.Core.Dtos;
using ConsolidationTool.Data.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Service.Interfaces.ProductManagement
{
    public interface ICategoryServices
    {
        Task<string> AddOneAsync(CategoryDto input);
        Task<IEnumerable<CategorizationTbl>> GetAllAsync();
        Task<CategorizationTbl> GetByIdAsync(int id);
    }
}
