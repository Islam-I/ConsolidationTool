using ConsolidationTool.Core.Dtos;
using ConsolidationTool.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Service.Interfaces.ProductManagement
{
    public interface IPropertyServices
    {
        Task<string> AddOneAsync(PropertyDto input);
        Task<IEnumerable<Property>> GetAllAsync();
        Task<Property> GetByIdAsync(int id);
    }
}
