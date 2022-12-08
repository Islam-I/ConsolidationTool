using ConsolidationTool.Data.Models;
using ConsolidationTool.Repository.GenericRepository;
using ConsolidationTool.Repository.NonGenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Repository.UnitOfWork
{

    public interface IUnitOfWork : IDisposable
    {
        BaseRepository<T> GetRepository<T>(bool newRepo = false) where T : class;

        IBaseRepository<Category> Category { get; }
        IBaseRepository<SubCategory> SubCategory { get; }
        IBaseRepository<Property> Property { get; }
        //IBooksRepository Books { get; }
        Task<int> CompleteAsync();
        int Complete();
    }
}