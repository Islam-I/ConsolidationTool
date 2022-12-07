using ConsolidationTool.Core.Dtos;
using ConsolidationTool.Data.Models;
using ConsolidationTool.Repository.UnitOfWork;
using ConsolidationTool.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Service.Services
{
    public class CustomerService : ICustomerService
    {
        public IUnitOfWork _unitOfWork { get; set; }

        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> AddOne(CustomerInputDto input)
        {
            Customer model = new Customer();
            model.City = input.City;
            model.Country = input.Country;
            model.LastName = input.LastName;
            model.FirstName = input.FirstName;
            model.Phone = input.Phone;
            await _unitOfWork.GetRepository<Customer>().Add(model);
            await _unitOfWork.CompleteAsync();
            return "success";
        }
        public async Task<List<Customer>> GetAll(int id = 0)
        {
            if (id != 0)
                return await _unitOfWork.GetRepository<Customer>().GetAll(a => a.Id == id);
            else
                return await _unitOfWork.GetRepository<Customer>().GetAll();
        }

        public async Task<Customer> GetById(int id)
        {
            //if (id != null)
                return await _unitOfWork.GetRepository<Customer>().GetById(id);

        }
    }
}
