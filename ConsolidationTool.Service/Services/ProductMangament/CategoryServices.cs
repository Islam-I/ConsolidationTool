using ConsolidationTool.Core.Dtos;
using ConsolidationTool.Data.DBModels;
using ConsolidationTool.Repository.UnitOfWork;
using ConsolidationTool.Service.Interfaces.ProductManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Service.Services.ProductMangament
{
    public class CategoryServices : ICategoryServices
    {
        public IUnitOfWork _unitOfWork { get; set; }
        public CategoryServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> AddOneAsync(CategoryDto input)
        {
            return "success";
        }

        public async Task<IEnumerable<CategorizationTbl>> GetAllAsync()
        {
            return await _unitOfWork.GetRepository<CategorizationTbl>().GetAllAsync();
        }

        public async Task<CategorizationTbl> GetByIdAsync(int id)
        {
            return await _unitOfWork.GetRepository<CategorizationTbl>().GetByIdAsync(id);
        }

    }
}
