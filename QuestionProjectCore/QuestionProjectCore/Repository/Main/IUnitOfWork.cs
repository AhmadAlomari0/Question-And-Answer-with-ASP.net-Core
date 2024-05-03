using QuestionProjectCore.Models;

namespace QuestionProjectCore.Repository.Main
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<Answer> answer { get; }
        IRepository<Category> categories { get; }
        IRepository<Question> questions { get; }
        IRepository<Report> reports { get; }
        IRepository<Member> members { get; }
        IModeratorRepo moderators { get; }

        int CommitChanges();
    }
}
