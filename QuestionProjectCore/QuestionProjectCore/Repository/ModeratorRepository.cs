using Microsoft.CodeAnalysis.CSharp.Syntax;
using QuestionProjectCore.Models;
using QuestionProjectCore.Repository.Main;

namespace QuestionProjectCore.Repository
{
    public class ModeratorRepository : MainRepository<Moderator>, IModeratorRepo
    {
        public ModeratorRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        private readonly AppDbContext _context;

        public decimal GetSalary(Moderator moderator)
        {
            throw new Exception();
        }

        public void SetSalary(Moderator moderator)
        {
            _context.Add(moderator);
        }
    }
}
