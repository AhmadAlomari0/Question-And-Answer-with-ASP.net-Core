using Microsoft.AspNetCore.Identity;
using QuestionProjectCore.Repository.Main;

namespace QuestionProjectCore.Repository
{
    public class AdminRepo : MainRepository<IdentityUser>, IAdminRepo
    {
        private readonly AppDbContext _context;

        public AdminRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public string GetRoleName()
        {
            return "";
        }

        public string GetUsername()
        {
            throw new NotImplementedException();
        }
    }
}
