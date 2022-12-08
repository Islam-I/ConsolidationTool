using ConsolidationTool.Core.Dtos;
using ConsolidationTool.Data.Models;
using ConsolidationTool.Repository.UnitOfWork;
using ConsolidationTool.Service.Interfaces.ProductManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Service.Services.ProductMangament
{
    public class PropertyServices : IPropertyServices
    {
        public IUnitOfWork _unitOfWork { get; set; }
        public PropertyServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<string> AddOneAsync(PropertyDto input)
        {
            Property model = new Property();
            model.Name = input.Name;
            model.Description = input.Description;
            model.SubCategoryId = input.SubCategoryId;
            await _unitOfWork.GetRepository<Property>().AddAsync(model);
            await _unitOfWork.CompleteAsync();
            return "success";
        }

        public async Task<IEnumerable<Property>> GetAllAsync()
        {
                return await _unitOfWork.GetRepository<Property>().GetAllAsync();
        }

        public async Task<Property> GetByIdAsync(int id)
        {
            return await _unitOfWork.GetRepository<Property>().GetByIdAsync(id);

        }
    }
}
