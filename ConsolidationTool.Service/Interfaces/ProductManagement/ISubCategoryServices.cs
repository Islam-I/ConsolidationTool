using ConsolidationTool.Core.Dtos;
using ConsolidationTool.Data.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Service.Interfaces.ProductManagement
{
    public interface ISubCategoryServices
    {
        Task<string> AddOneAsync(SubCategoryDto input);
        Task<IEnumerable<CategorizationDetailsTbl>> GetAllAsync();
        Task<CategorizationDetailsTbl> GetByIdAsync(int id);
    }
}
