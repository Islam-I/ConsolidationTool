using ConsolidationTool.Core.Dtos;
using ConsolidationTool.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Service.Interfaces
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAll(int id = 0);
        //Task<Customer> GetById(int id);
        Task<string> AddOne(CustomerInputDto input);
    }
}
