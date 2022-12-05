using ConsolidationTool.Repository.GenericRepository;
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
}