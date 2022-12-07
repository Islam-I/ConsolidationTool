using ConsolidationTool.Data.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ConsolidationTool.Repository.GenericRepository
{

    public class BaseRepository<T> where T : class
    {
        private readonly TestDBContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(TestDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<string> Add(T obj)
        {
            try
            {
                await _dbSet.AddAsync(obj);
                return "success";
            }
            catch (Exception e)
            {
                return "Failed with error : " + e.Message;
            };
        }

        public async Task<string> AddRange(List<T> obj)
        {
            try
            {
                await _dbSet.AddRangeAsync(obj);
                return "success";
            }
            catch (Exception e)
            {
                return "Failed with error : " + e.Message;
            };
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? await _dbSet.ToListAsync() : await _dbSet.Where(filter).ToListAsync();
        }

        public async Task<string> Update(T obj)
        {
            _dbSet.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            
            try
            {
                _dbSet.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                return "success";
            }
            catch (Exception e)
            {
                return "Failed with error : " + e.Message;
            };
        }

    }
}
