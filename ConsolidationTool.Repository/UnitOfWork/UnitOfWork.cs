using ConsolidationTool.Data.DatabaseContext;
using ConsolidationTool.Data.DBModels;
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
        private readonly ACT_TAX_INVOICE_CONSOLIDATIONContext _context;

        private readonly Dictionary<Type, object> _repositories = new Dictionary<Type, object>();
        //public IBooksRepository Books { get; private set; }

        public UnitOfWork(ACT_TAX_INVOICE_CONSOLIDATIONContext context)
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

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            var result = await _context.SaveChangesAsync();
            return result;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

    //public class UnitOfWork : IUnitOfWork
    //{
    //    private readonly TestDBContext _context;
    //    private readonly Dictionary<Type, object> _repositories = new Dictionary<Type, object>();

    //    public UnitOfWork(TestDBContext context)
    //    {
    //        _context = context;
    //    }

    //    public BaseRepository<T> GetRepository<T>(bool newRepo = false) where T : class//BaseEntity
    //    {
    //        Type newType = typeof(T);
    //        if (_repositories.ContainsKey(newType))
    //        {
    //            _repositories.Remove(newType);
    //        }
    //        _repositories.Add(newType, new BaseRepository<T>(_context));
    //        return (BaseRepository<T>)_repositories[newType];
    //    }

    //    public string Complete()
    //    {
    //        _context.SaveChanges();
    //        return "";
    //    }

    //    public async Task<string> CompleteAsync()
    //    {
    //        await _context.SaveChangesAsync();
    //        return "";
    //    }

    //    public void Dispose()
    //    {
    //        _context.Dispose();
    //    }
    //}

    //public class UnitOfWork : IUnitOfWork
    //{
    //    private readonly TestDBContext _context;

    //    public UnitOfWork(TestDBContext context)
    //    {
    //        Category = new CategoryRepository(_context);
    //        SubCategory = new SubCategoryRepository(_context);
    //        Property = new PropertyRepository(_context);
    //        _context = context;
    //    }
    //    public ICategoryRepository Category
    //    {
    //        get;
    //        private set;
    //    }
    //    public ISubCategoryRepository SubCategory
    //    {
    //        get;
    //        private set;
    //    }
    //    public IPropertyRepository Property
    //    {
    //        get;
    //        private set;
    //    }
    //    public void Dispose()
    //    {
    //        _context.Dispose();
    //    }
    //    public int Save()
    //    {
    //        return _context.SaveChanges();
    //    }
    //}

}

