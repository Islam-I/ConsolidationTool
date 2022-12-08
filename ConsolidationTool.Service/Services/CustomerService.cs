using ConsolidationTool.Core.Dtos;
using ConsolidationTool.Data.Models;
using ConsolidationTool.Repository.UnitOfWork;
using ConsolidationTool.Service.Interfaces;

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
            await _unitOfWork.GetRepository<Customer>().AddAsync(model);
            await _unitOfWork.CompleteAsync();
            return "success";
        }
        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _unitOfWork.GetRepository<Customer>().GetAllAsync();
        }

        public async Task<Customer> GetById(int id)
        {

            return await _unitOfWork.GetRepository<Customer>().GetByIdAsync(id);

        }
    }
}
