using Microsoft.AspNetCore.Identity;
using QuestionProjectCore.Models;
using QuestionProjectCore.Repository.Main;

namespace QuestionProjectCore.Repository
{
    public class AdminRepo : MainRepository<ApplicationUser>, IAdminRepo
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
