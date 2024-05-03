using QuestionProjectCore.Models;

namespace QuestionProjectCore.Repository.Main
{
    public interface IModeratorRepo : IRepository<Moderator>
    {
        decimal GetSalary(Moderator moderator);
        void SetSalary(Moderator moderator);
    }
}
