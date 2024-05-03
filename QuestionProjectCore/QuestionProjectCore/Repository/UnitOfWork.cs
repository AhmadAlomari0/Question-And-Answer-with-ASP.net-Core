using Microsoft.AspNetCore.Identity;
using QuestionProjectCore.Models;
using QuestionProjectCore.Repository.Main;

namespace QuestionProjectCore.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            answer = new MainRepository<Answer>(_context);
            categories = new MainRepository<Category>(_context);
            moderators = new ModeratorRepository(_context);
            questions = new MainRepository<Question>(_context);
            reports = new MainRepository<Report>(_context);
            members = new MainRepository<Member>(_context);
            //admin = new MainRepository<IdentityUser>(_context);
        }
        private readonly AppDbContext _context;

        public IRepository<Answer> answer { get; private set; }

        public IRepository<Category> categories { get; private set; }

        public IRepository<Question> questions { get; private set; }

        public IRepository<Report> reports { get; private set; }

        public IRepository<Member> members { get; private set; }
        public IModeratorRepo moderators { get; private set; }
        //public IAdminRepo<IdentityUser> admin { get; private set; }


        public int CommitChanges() => _context.SaveChanges();

        public void Dispose() => _context.Dispose();
    }
}
