using Microsoft.EntityFrameworkCore;
using QuestionProjectCore.Repository.Main;
using System.Linq.Expressions;

namespace QuestionProjectCore.Repository
{
    public class MainRepository<T> : IRepository<T> where T : class
    {
        protected AppDbContext _context;
        public MainRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(T? item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }
        public void Update(T? item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }

        public void Delete(T? item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public IEnumerable<T>? GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public IEnumerable<T> GetAll(params string[] eagers)
        {
            IQueryable<T> query = _context.Set<T>();

            if(eagers.Length > 0)
            {
                foreach (var eager in eagers)
                {
                    query = query.Include(eager);
                }
            }
            return query.ToList();

        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(params string[] eagers)
        {
            IQueryable<T> query = _context.Set<T>();

            if (eagers.Length > 0)
            {
                foreach (var eager in eagers)
                {
                    query = query.Include(eager);
                }
            }
            return await query.ToListAsync();

        }

        public T GetByID(int? id)
        {
            return _context.Set<T>().Find(id);
        }

        public async Task<T> GetByIDAsync(int? id)
        {
             return await _context.Set<T>().FindAsync(id);
        }

        public T SelectOne(Expression<Func<T, bool>> match)
        {
            return _context.Set<T>().SingleOrDefault(match);
        }
    }
}
