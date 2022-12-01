using ConsolidationTool.Data.DatabaseContext;
using ConsolidationTool.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TestDBContext _context;
        private readonly Dictionary<Type, object> _repositories = new Dictionary<Type, object>();
        public UnitOfWork(TestDBContext context)
        {
            _context = context;
        }

        public BaseRepository<T> GetRepository<T>(bool newRepo = false) where T : class//BaseEntity
        {
            Type newType = typeof(T);
            if (_repositories.ContainsKey(newType))
            {
                _repositories.Remove(newType);
            }
            _repositories.Add(newType, new BaseRepository<T>(_context));
            return (BaseRepository<T>)_repositories[newType];
        }
        public string Complete()
        {
            _context.SaveChanges();
            return "";
        }
        public async Task<string> CompleteAsync()
        {
            await _context.SaveChangesAsync();
            return "";
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

