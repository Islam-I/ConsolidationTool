using ConsolidationTool.Core.Dtos;
using ConsolidationTool.Data.Models;
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
        Task<IEnumerable<SubCategory>> GetAllAsync();
        Task<SubCategory> GetByIdAsync(int id);
    }
}
