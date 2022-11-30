using ConsolidationTool.Data.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Repository.GenericRepository
{
    public class BaseRepository<T> where T : class
    {
        private TestDBContext _context;
        private DbSet<T> _dbSet;
        public BaseRepository(TestDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }
        public async Task<string> add(T emp)
        {
            try
            {
                await _dbSet.AddAsync(emp);
                return "success";
            }
            catch (Exception e)
            {
                return "Failed with error : " + e.Message;
            };
        }
        public async Task<string> addRange(List<T> emp)
        {
            try
            {
                await _dbSet.AddRangeAsync(emp);
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
    }
}
