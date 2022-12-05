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
        string Complete();
        Task<string> CompleteAsync();
    }

    //public interface IUnitOfWork : IDisposable
    //{
    //    ICategoryRepository Category { get; }
    //    ISubCategoryRepository SubCategory { get; }
    //    IPropertyRepository Property { get; }

    //    int Save();
    //}
}