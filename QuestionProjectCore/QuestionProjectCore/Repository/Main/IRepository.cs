using System.Linq.Expressions;

namespace QuestionProjectCore.Repository.Main
{
    public interface IRepository<T> where T : class
    {
        void Add(T? item);
        void Update(T? item);
        void Delete(T? item);
        T GetByID(int? id);
        Task<T> GetByIDAsync(int? id);
        T SelectOne(Expression<Func<T,bool>> match);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(params string[] eagers);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params string[] eagers);
    }
}
