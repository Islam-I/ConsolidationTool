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
    public class SubCategoryServices : ISubCategoryServices
    {
        public IUnitOfWork _unitOfWork { get; set; }
        public SubCategoryServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<string> AddOneAsync(SubCategoryDto input)
        {
            //SubCategory model = new SubCategory();
            //model.Name = input.Name;
            //model.Description = input.Description;
            //model.CategoryId = input.CategoryId;
            //await _unitOfWork.GetRepository<SubCategory>().AddAsync(model);
            //await _unitOfWork.CompleteAsync();
            return "success";
        }

        public async Task<IEnumerable<CategorizationDetailsTbl>> GetAllAsync()
        {
                return await _unitOfWork.GetRepository<CategorizationDetailsTbl>().GetAllAsync();
        }

        public async Task<CategorizationDetailsTbl> GetByIdAsync(int id)
        {
            return await _unitOfWork.GetRepository<CategorizationDetailsTbl>().GetByIdAsync(id);

        }
    }
}
