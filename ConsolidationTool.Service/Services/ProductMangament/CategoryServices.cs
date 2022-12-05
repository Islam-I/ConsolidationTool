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
    public class CategoryServices : ICategoryServices
    {
        public IUnitOfWork _unitOfWork { get; set; }
        public CategoryServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<string> AddOne(CategoryDto input)
        {
            Category model = new Category();
            model.Name = input.Name;
            model.Description = input.Description;
            await _unitOfWork.GetRepository<Category>().Add(model);
            await _unitOfWork.CompleteAsync();
            return "success";
        }

        public async Task<List<Category>> GetAll(int id = 0)
        {
            if (id != 0)
                return await _unitOfWork.GetRepository<Category>().GetAll(a => a.Id == id);
            else
                return await _unitOfWork.GetRepository<Category>().GetAll();
        }

        //public async Task<Customer> GetById(int id)
        //{
        //    //if (id != null)
        //    return await _unitOfWork.GetRepository<Customer>().GetById(id);

        //}
    }
}
